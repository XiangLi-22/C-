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
        bool Update(params SqlParameter[] sqlParameters);
        bool Delete(int id);
        List<DayDTO> Select(string time);
        IQueryable<DayDTO> GetList();
        T GetModel(int id);
        int TotalPage(int pageSize);
    }
}
