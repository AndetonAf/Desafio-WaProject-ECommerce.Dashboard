using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaProject.ECommerce.Dashboard.Data.ViewModels
{
    public class Paginacao
    {
        public Object Data { get; set; }
        public int Total { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
