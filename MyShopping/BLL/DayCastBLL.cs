using Domains;
using Domains.DTO;
using Maticsoft.Model;
using SQLDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;

namespace BLL
{
    public class DayCastBLL
    {
        DayCastDAL dayCastDAL = new DayCastDAL();

        /// <summary>
        /// 获取指定天的数据
        /// </summary>
        /// <param name="time">指定的日期</param>
        /// <returns>数据</returns>
        public List<DayDTO> SelectSpecifyTime(DateTime time, int page, int pagesize,out string message)
        {
            var query = dayCastDAL.Select(time,page,pagesize);
            if (query.Count == 0) message = $"{time.ToString("yyyy年MM月dd日")}没有消费记录!";
            else message = string.Empty;
            return query;
        }

        /// <summary>
        /// 获取当天的消费数据
        /// </summary>
        /// <returns></returns>
        public async Task<(List<DayDTO> list, string message)> GetTodayCastAsync(int page, int pagesize)
        {
            var query = dayCastDAL.GetList(page,pagesize);
            var list = await query.ToListAsync();
            string message = list.Count == 0 ? "你还没有添加当日消费记录!" : string.Empty;
            return (list, message);
        }



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

        /// <summary>
        /// 获取指定类型的总消费记录并分页
        /// </summary>
        /// <param name="t"></param>
        /// <param name="page"></param>
        /// <param name="pagesize"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public List<DayDTO> GetTypeCast(int t,int page, int pagesize,out string message)
        {
            message = string.Empty;
            var list =  dayCastDAL.GetTypeCast(t,page,pagesize).ToList<DayDTO>();
            if (list.Count == 0) message = "本月没有消费记录!";
            return list;
        }

        /// <summary>
        /// 获取总页数
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TotalPage(int pageSize, int t = -1)
        {
            return dayCastDAL.TotalPage(pageSize, t);
        }

        /// <summary>
        /// 获取指定时间的总页数
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public int TimeTotalPage(int pageSize, DateTime time)
        {
            return dayCastDAL.TimeTotalPage(pageSize, time);
        }
    }
}
