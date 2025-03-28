using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DTO
{
    public class DayDTO
    {
        public int Id { get; set; }

        public string GoodsName { get; set; }

        public GoodsType GoodsType { get; set; }

        public float GoodsPrice { get; set; }

        public float DaysCast { get; set; }

        public float TotalRemain { get; set; }

        public DateTime CurrentTime { get; set; }

        public string State { get; set; }  
    }
}
