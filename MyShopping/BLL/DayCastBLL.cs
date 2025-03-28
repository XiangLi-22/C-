using Maticsoft.Model;
using SQLDAL;
using System;

namespace BLL
{
    public class DayCastBLL
    {
        DayCastDAL dayCastDAL = new DayCastDAL();

        /// <summary>
        /// 向数据库添加消费数据
        /// </summary>
        /// <param name="model"></param>
        /// <param name="message"></param>
        public void Add(DayCastInfo model, out string message)
        {
            message = string.Empty;
            DayCastInfo m = new DayCastInfo();
            m.GoodsName = model.GoodsName;
            m.GoodsType = model.GoodsType;
            m.GoodsPrice = model.GoodsPrice;
            m.CurrentTime = model.CurrentTime == null ? DateTime.Now : model.CurrentTime;
            if (dayCastDAL.GetLastDayCost()!=null && 
                dayCastDAL.GetLastDayCost().CurrentTime.Month == m.CurrentTime.Month && 
                dayCastDAL.GetLastDayCost().CurrentTime.Day == m.CurrentTime.Day)
                m.DaysCast = dayCastDAL.GetLastDayCost().DaysCast + model.GoodsPrice;
            else m.DaysCast = model.GoodsPrice;
            m.TotalRemain = dayCastDAL.GetLastDayCost()==null?1500:dayCastDAL.GetLastDayCost().TotalRemain - model.GoodsPrice;

            if (!dayCastDAL.Add(m))
            {
                message = "添加失败!";
            }

            MothCastBLL mothCastBLL = new MothCastBLL();
            mothCastBLL.MothAdd(m.GoodsType, m.GoodsPrice);

            message = "添加成功!";
        }

        /// <summary>
        /// 获取上一条数据的剩余金额
        /// </summary>
        /// <returns></returns>
        public float GetLastRemainMoney()
        {
            if(dayCastDAL.GetLastDayCost()==null) return 1500;

            return dayCastDAL.GetLastDayCost().TotalRemain;
        }
    }
}
