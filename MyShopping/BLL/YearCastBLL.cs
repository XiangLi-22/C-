using SQLDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class YearCastBLL
    {
        YearCastDAL yearCastDAL = new YearCastDAL();

        /// <summary>
        /// 获取指定年的月总消费
        /// </summary>
        /// <param name="year"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public List<float> GetMothCost(int year,out string message)
        {
            message = string.Empty;
            var l = yearCastDAL.GetMothCost(year);
            var list = new List<float>();
            for (int i = 0; i < l.Count; i++){
                if (l[i]<0)
                {
                    list.Add(Math.Abs(l[i])+1500);
                }
                list.Add(1500-l[i]);
            }
            if (list.Count == 0) message = $"{year}年没有消费记录!";
            return list;
        }

        public Dictionary<string, float> GetMothType(int year, out string message)
        {
            message = string.Empty;
            Dictionary<string, float> d = yearCastDAL.GetMothType(year);
            if (d.Count == 0) message = $"{year}年每月消费记录!";
            return d;
        }
    }
}
