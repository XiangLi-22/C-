using Domains;
using Domains.Context;
using Domains.DTO;
using IDAL;
using Maticsoft.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace SQLDAL
{
    public class DayCastDAL : IDayCost
    {
        ShoppingModel c = new ShoppingModel();

        public bool Add(DayCastInfo model)
        {
            #region dapper
            //double daysCost = 0;
            //float totalMoney = 0;
            ////在这里调用getmodel(),查看上一个dascost

            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    // 执行查询，返回 DaysCost 和 TotalRemain
            //    var lastDayData = GetLastDayCost();

            //    // 如果查询到上一个记录，则进行赋值
            //    if (lastDayData != null)
            //    {
            //        daysCost = lastDayData.DaysCost;
            //        totalMoney = lastDayData.TotalRemain;
            //    }
            //    else
            //    {
            //        // 如果没有记录，设置默认值（比如为 0 或其他合适的默认值）
            //        daysCost = 0;
            //        var money = GetLastDayCost();
            //        if (money != null)
            //            totalMoney = money.TotalRemain;
            //        else
            //            totalMoney = 1500;
            //    }


            //    object obj = new
            //    {
            //        N = model.GoodName,
            //        P = model.price,
            //        Type = model.Type,
            //        TM = totalMoney-daysCost-model.price,
            //        DC = daysCost + model.price,    
            //        Time = DateTime.Now,
            //    };
            //    string sql = "INSERT INTO DayCost (GoodName, Price, Type, TotalRemain, DaysCost, Time) VALUES (@N, @P, @Type, @TM, @DC, @Time);";
            //    sqlConnection.Execute(sql, obj);
            //}
            //return true;
            #endregion

            c.DayCastInfo.Add(model);
            int row = c.SaveChanges();
            return row == 1;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DayDTO> GetList()
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
        public List<DayDTO> Select(string time)
        {
            var query = from d in c.DayCastInfo
                        //where d.CurrentTime.ToString("yyyy-MM-dd") == time
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
            c.SaveChanges();
            var list = query.ToList();
            list = list.FindAll(l => l.CurrentTime.ToString("yyyy-MM-dd") == time);
            return list;
        }

        public int TotalPage(int pageSize)
        {
            throw new NotImplementedException();
        }

        public bool Update(params SqlParameter[] sqlParameters)
        {
            throw new NotImplementedException();
        }
        public DayCastInfo GetLastDayCost()
        {
            #region dapper
            //DayCost lastDayCost = null;

            //using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            //{
            //    string getLastDayCostSql = @"
            //            SELECT TOP 1 
            //                Id, 
            //                GoodName, 
            //                Type, 
            //                Price, 
            //                Time, 
            //                TotalRemain, 
            //                DaysCost, 
            //                State
            //            FROM DayCost
            //            WHERE Time < GETDATE()
            //            ORDER BY Time DESC;";

            //    // 执行查询并映射结果
            //    lastDayCost = sqlConnection.QuerySingleOrDefault<DayCost>(getLastDayCostSql);
            //}

            //return lastDayCost;
            #endregion
            var lastRecord = c.DayCastInfo.OrderByDescending(x => x.Id).FirstOrDefault();
            return lastRecord;
        }
    }
}
