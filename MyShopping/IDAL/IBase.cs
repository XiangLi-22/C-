using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maticsoft.Model;
using Domains.DTO;

namespace IDAL
{
    public interface IBase<T> where T : class
    {
        bool Add(T modal);
        bool Update(int id);
        float Delete(int id);
        List<DayDTO> Select(DateTime time,int page,int pagesize);
        IQueryable<DayDTO> GetList(int page, int pagesize);
        T GetModel(int id);
        int TotalPage(int pageSize, int t);
    }
}
