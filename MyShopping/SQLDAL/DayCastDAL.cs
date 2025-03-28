using Domains.Context;
using IDAL;
using Maticsoft.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace SQLDAL
{
    public class DayCastDAL : IDayCost
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
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

        public DataSet GetList(int currentPage, int pageSize)
        {
            throw new NotImplementedException();
        }

        public DayCastInfo GetModel(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet Select(params SqlParameter[] sqlParameters)
        {
            throw new NotImplementedException();
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
