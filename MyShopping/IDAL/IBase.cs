using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBase<T> where T : class
    {
        bool Add(T modal);
        bool Update(params SqlParameter[] sqlParameters);
        bool Delete(int id);
        DataSet Select(params SqlParameter[] sqlParameters);
        DataSet GetList(int currentPage, int pageSize);
        T GetModel(int id);
        int TotalPage(int pageSize);
    }
}
