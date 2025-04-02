using Domains.Context;
using Hepler;
using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLDAL
{
    public class YearCastDAL
    {
        ShoppingModel c = new ShoppingModel();

        /// <summary>
        /// 获取指定年每月剩余金额
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<float> GetMothCost(int year)
        {
            var query = c.MothCastInfo.Where(m=>m.CurrentTime.Year == year).Select(m=>m.TotalRemain);
            var list = query.ToList();
            return list;
        }

        /// <summary>
        /// 获取类型名和类型值
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public Dictionary<string,float> GetMothType(int year)
        {
            var list = typeof(MothCastInfo).GetProperties().Select(p => p.Name).ToList();
            var yearList = c.MothCastInfo.Where(m => m.CurrentTime.Year == year).ToList();
            Dictionary<string, float> d = new Dictionary<string, float>();
            for (int i = 0; i < list.Count; i++)
            {
                string name = ProperNameConvertGoodsTypeName.GetPropName(list[i]);
                if (name == null) continue;
                float sum = 0;
                foreach (var item in yearList)
                {
                    var prop = typeof(MothCastInfo).GetProperty(list[i]);
                    if (prop != null) 
                    // GetValue 需要的是一个对象实例。因此，应该传入 item（具体的 MothCastInfo 实例）。
                        sum += Convert.ToSingle(prop.GetValue(item));
                }

                d.Add(name, sum);
            }
            return d;
        }

    }
}
