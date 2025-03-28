using Domains.Context;
using IDAL;
using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDAL
{
    public class MothCastDAL : IMothCost
    {
        ShoppingModel context = new ShoppingModel();

        

        /// <summary>
        /// 更新本月的数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(MothCastInfo model)
        {
            context.Entry(model).State = EntityState.Modified;
            int row = context.SaveChanges();
            return row == 1;
        }

        public List<DayCastInfo> GetMothCosts()
        {
            DateTime dt = DateTime.Now;
            var query = context.DayCastInfo.Where(d => d.CurrentTime.Month == dt.Month);
            return query.ToList<DayCastInfo>();

        }

        /// <summary>
        /// 添加初始数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(MothCastInfo model)
        {
            context.MothCastInfo.Add(model);
            int row = context.SaveChanges();
            return row==1;
        }

        /// <summary>
        /// 获取上一条数据 ,如果没有数据就添加一条初始数据
        /// </summary>
        /// <returns></returns>
        public MothCastInfo GetLastMonth()
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            var query = context.MothCastInfo.Where(m => m.CurrentTime.Year == year && m.CurrentTime.Month == month).OrderByDescending(m => m.CurrentTime).FirstOrDefault();

            if (query != null) return query;

            var newModel = new MothCastInfo
            {
                CurrentTime = DateTime.Now,
                TotalRemain = 1500 // 如果你有默认值，也可以改
            };
            context.MothCastInfo.Add(newModel);
            context.SaveChanges();
            return newModel;
        }

        /// <summary>
        /// 获取指定月的数据
        /// </summary>
        /// <returns></returns>
        public MothCastInfo GetCurrentMonth(int moth)
        {
            var query = context.MothCastInfo.Where(m=>m.CurrentTime.Month==moth);
            return query.FirstOrDefault();
        }
    }
}
