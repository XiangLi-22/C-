using Domains;
using Domains.Context;
using Domains.DTO;
using IDAL;
using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace SQLDAL
{
    public class DayCastDAL : IDayCost
    {
        ShoppingModel c = new ShoppingModel();

        /// <summary>
        /// 添加当日消费
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(DayCastInfo model)
        {
            c.DayCastInfo.Add(model);
            int row = c.SaveChanges();
            return row == 1;
        }

        /// <summary>
        /// 获取当月指定消费类型的所有消费记录的数据
        /// </summary>
        /// <param name="t">指定的类型</param>
        /// <returns></returns>
        public IQueryable<DayDTO> GetTypeCast(int t, int page, int pagesize)
        {
            int dt = DateTime.Now.Month;
            var query = c.DayCastInfo.Where(d => d.GoodsType == t && d.CurrentTime.Month == dt)
                .Select(d => new DayDTO()
                {
                    Id = d.Id,
                    GoodsName = d.GoodsName,
                    GoodsType = (GoodsType)d.GoodsType,
                    GoodsPrice = d.GoodsPrice,
                    DaysCast = d.DaysCast,
                    TotalRemain = d.TotalRemain,
                    CurrentTime = d.CurrentTime,
                    State = d.State == 0 ? "正常" : "已退款"
                });
            query = query.OrderByDescending(q => q.CurrentTime).Skip((page - 1) * pagesize).Take(pagesize);
            return query;
        }

        /// <summary>
        /// 对指定的商品进行退款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public float Delete(int id)
        {
            //找到当日消费的指定数据,由id找,将状态改成已退款,并且颜色为蓝色
            DayCastInfo d = c.DayCastInfo.Find(id);
            d.State = 1;
            c.Entry(d).State = EntityState.Modified;
            c.SaveChanges();
            return d.GoodsPrice;
        }

        /// <summary>
        /// 获取日消费所有数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<DayDTO> GetList(int page, int pagesize)
        {
            DateTime start = DateTime.Parse($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} 00:00:00");
            DateTime end = DateTime.Parse($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} 23:59:59");
            var query = from d in c.DayCastInfo
                        where d.CurrentTime >= start && d.CurrentTime <= end
                        orderby d.CurrentTime ascending
                        select new DayDTO()
                        {
                            Id = d.Id,
                            GoodsName = d.GoodsName,
                            GoodsType = (GoodsType)d.GoodsType,
                            GoodsPrice = d.GoodsPrice,
                            DaysCast = d.DaysCast,
                            TotalRemain = d.TotalRemain,
                            CurrentTime = d.CurrentTime,
                            State = d.State == 0 ? "正常" : "已退款",
                        };
            query = query.OrderByDescending(d => d.CurrentTime).Skip((page - 1) * pagesize).Take(pagesize);
            return query;
        }

        public DayCastInfo GetModel(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取指定天的数据
        /// </summary>
        /// <param name="time"></param>
        /// <returns>数据</returns>
        public List<DayDTO> Select(DateTime time, int page, int pagesize)
        {
            var query = c.DayCastInfo
                        .Where(l => l.CurrentTime.Year == time.Year && l.CurrentTime.Month == time.Month && l.CurrentTime.Day == time.Day)
                        .Select(d => new DayDTO()
                        {
                            Id = d.Id,
                            GoodsName = d.GoodsName,
                            GoodsType = (GoodsType)d.GoodsType,
                            GoodsPrice = d.GoodsPrice,
                            DaysCast = d.DaysCast,
                            TotalRemain = d.TotalRemain,
                            CurrentTime = d.CurrentTime,
                            State = d.State == 0 ? "正常" : "已退款",
                        });

            var list = query.OrderByDescending(d => d.DaysCast).Skip((page - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }


        /// <summary>
        /// 获取指定日期的总页数
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public int TimeTotalPage(int pageSize, DateTime time)
        {
            var query = c.DayCastInfo
                        .Where(l => l.CurrentTime.Year == time.Year && l.CurrentTime.Month == time.Month && l.CurrentTime.Day == time.Day);
            var list = query.ToList();
            return (int)Math.Ceiling(list.Count / (double)pageSize);
        }

        /// <summary>
        /// 获取类型总页数或者当日总页数
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int TotalPage(int pageSize, int t)
        {
            DateTime start = DateTime.Parse($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} 00:00:00");
            DateTime end = DateTime.Parse($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day} 23:59:59");
            int month = DateTime.Now.Month;

            var query = c.DayCastInfo.Where(m => m.CurrentTime.Month == month).Where(d => d.GoodsType == t);
            if (t == -1) query = c.DayCastInfo.Where(d => d.CurrentTime >= start && d.CurrentTime <= end);
            var list = query.ToList();
            return (int)Math.Ceiling(list.Count / (double)pageSize);
        }

        public bool Update(int id)
        {
            return true;
        }

        /// <summary>
        /// 获取本月的剩余消费
        /// 查询每月的消费是否存在,如果不存在剩余消费就是2000开始,如果存在就按上一个数据的剩余消费开始
        /// </summary>
        /// <returns></returns>
        public float GetTotalRemain()
        {
            int month = DateTime.Now.Month;
            var totalRemain = c.MothCastInfo.FirstOrDefault(x => x.CurrentTime.Month == month) == null ? 2000 : c.MothCastInfo.FirstOrDefault(x => x.CurrentTime.Month == month).TotalRemain;
            return totalRemain;
        }

        /// <summary>
        /// 获取指定日期的最后消费
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public DayCastInfo GetLastDayCost(DateTime time)
        {
            int day = time.Day;
            var value = c.DayCastInfo.Where(d => d.CurrentTime.Day == day).OrderByDescending(d => d.DaysCast).FirstOrDefault();
            return value;
        }

        
    }
}
