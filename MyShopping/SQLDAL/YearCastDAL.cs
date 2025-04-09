using Domains.Context;
using Hepler;
using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            // 先确保数据已添加，只有当数据缺失时才调用 Add(year)
            EnsureYearDataExists(year);
            Update(year);

            var query = c.YearCastInfo.Where(m => m.CurrentTime.Year == year).Select(m => m.Cast);
            var list = query.ToList();

            return list;
        }

        /// <summary>
        /// 确保某年数据已存在，不存在时添加
        /// </summary>
        private void EnsureYearDataExists(int year)
        {
            // 检查是否已经存在该年的 YearCastInfo 数据
            bool yearDataExists = c.YearCastInfo.Any(y => y.CurrentTime.Year == year);

            if (!yearDataExists)
            {
                // 如果该年的数据不存在，则添加该年的月消费数据
                Add(year);
            }
        }

        /// <summary>
        /// 获取指定年的总类型名和类型值
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

        /// <summary>
        /// 添加某年某月的消费的初始值
        /// </summary>
        public void Add(int year)
        {
            List<YearCastInfo> list = new List<YearCastInfo>();
            for (int i = 1; i <= 12; i++)
            {
                // 检查list中是否已经包含相同年份和月份的 YearCastInfo 实例
                var existingItem = list.FirstOrDefault(item => item.Moth == i && item.CurrentTime.Year == year);
                if (existingItem != null)
                {
                    // 如果 list 中已包含相同年份和月份的 YearCastInfo 实例，则跳过本次循环
                    continue;
                }
                list.Add(new YearCastInfo()
                { 
                    Moth = i , 
                    Cast = c.MothCastInfo.FirstOrDefault(m => m.CurrentTime.Month == i && m.CurrentTime.Year == year) == null?0: 2000 - c.MothCastInfo.FirstOrDefault(m => m.CurrentTime.Month == i && m.CurrentTime.Year == year).TotalRemain  ,
                    CurrentTime = c.MothCastInfo.FirstOrDefault(m => m.CurrentTime.Month == i && m.CurrentTime.Year == year) == null ? DateTime.Parse($"{year}-{i}-1 00:00:00") : c.MothCastInfo.FirstOrDefault(m => m.CurrentTime.Month == i).CurrentTime,
                });
            }
            c.YearCastInfo.AddRange(list);
            c.SaveChanges();
        }

        /// <summary>
        /// 更新某年某月的消费
        /// </summary>
        public void Update(int year)
        {
            for (int i = 1; i <= 12; i++)
            {
                // 获取该月的数据
                var monthCastInfo = c.MothCastInfo.FirstOrDefault(m => m.CurrentTime.Month == i && m.CurrentTime.Year == year);

                if (monthCastInfo != null)
                {
                    // 查找数据库中是否存在对应的 YearCastInfo 实例
                    var existingItem = c.YearCastInfo.FirstOrDefault(item => item.Moth == i && item.CurrentTime.Year == year);

                    if (existingItem != null)
                    {
                        // 更新现有记录
                        existingItem.Cast = 2000 - monthCastInfo.TotalRemain;
                        existingItem.CurrentTime = monthCastInfo.CurrentTime;

                        // 标记实体为已修改
                        c.Entry(existingItem).State = EntityState.Modified;
                    }
                    else
                    {
                        // 如果不存在对应记录，则添加新的 YearCastInfo 实例
                        c.YearCastInfo.Add(new YearCastInfo()
                        {
                            Moth = i,
                            Cast = 2000 - monthCastInfo.TotalRemain,
                            CurrentTime = monthCastInfo.CurrentTime,
                        });
                    }
                }
                else
                {
                    // 如果没有找到对应的 MothCastInfo，则可以决定是否需要添加默认值或跳过
                    // 比如：你可以选择添加一个默认值
                }
            }

            // 保存更改
            c.SaveChanges();
        }

    }
}
