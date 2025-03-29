using Domains;
using Hepler;
using Maticsoft.Model;
using SQLDAL;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace BLL
{
    public class MothCastBLL
    {
        MothCastDAL mothCastDAL = new MothCastDAL();
        //public double GetTypeCouunt(int index)
        //{
        //    List<DayCastInfo> list = mothCastDAL.GetMothCosts();
        //    return 1.0;
        //}

        /// <summary>
        /// 当添加日消费时,更新月消费
        /// </summary>
        /// <param name="type"></param>
        /// <param name="price"></param>
        public void MothAdd(int type,float price)
        {
            var monthModel = mothCastDAL.GetLastMonth();
            monthModel.TotalRemain = mothCastDAL.GetLastMonth().TotalRemain - price;
            GoodsType goodsType =  (GoodsType)type;
            string t = GoodsTypeExtensions.GetMonthlyFieldName(goodsType);

            //反射获取字段属性   字段名是 "FoodPrice" → 取出 MothCastInfo.FoodPrice 属性对象
            var prop = typeof(MothCastInfo).GetProperty(t);  //重要
            float oldValue = Convert.ToSingle(prop.GetValue(monthModel));
            prop.SetValue(monthModel, oldValue + price);
            mothCastDAL.Update(monthModel);
        }

        /// <summary>
        /// 获取每个类型的消费金额
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public float GetMothTypePrice(int type)
        {
            var moth = DateTime.Now.Month;
            var model = mothCastDAL.GetCurrentMonth(moth);
            GoodsType goodsType = (GoodsType)type;
            string t = GoodsTypeExtensions.GetMonthlyFieldName(goodsType);
            var prop = typeof(MothCastInfo).GetProperty(t);
            return Convert.ToSingle(prop.GetValue(model));
        }

        /// <summary>
        /// 获取本月的数据
        /// </summary>
        /// <returns></returns>
        public MothCastInfo GetCurrentMonth()
        {
            var moth = DateTime.Now.Month;
            return mothCastDAL.GetCurrentMonth(moth);
        }

    }
}
