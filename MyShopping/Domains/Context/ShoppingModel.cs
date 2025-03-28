using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Context
{
    public class ShoppingModel:DbContext
    {
        public ShoppingModel():base("name=ConnString") { }

        //定义数据集
        public virtual DbSet<DayCastInfo> DayCastInfo {  get; set; }
        public virtual DbSet<MothCastInfo> MothCastInfo {  get; set; }
        public virtual DbSet<YearCastInfo> YearCastInfo {  get; set; }
    }
}
