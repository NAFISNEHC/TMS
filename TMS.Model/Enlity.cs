using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    public class Enlity
    {
        public string BillNo { get; set; }
        public string Code { get; set; }
        public int SeqID { get; set; }
        public DateTime RegData { get; set; }
        public int UsedCount { get; set; }
        public string Location { get; set; }
    }
}
