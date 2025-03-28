using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IMothCost
    {
        //List<DayCastInfo> GetMothCosts();

        MothCastInfo GetLastMonth();
        MothCastInfo GetCurrentMonth(int moth);

        bool Update(MothCastInfo model);
        bool Add(MothCastInfo model);
    }
}
