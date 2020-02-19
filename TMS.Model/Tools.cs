using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace TMS.Model
{
    public class Tools
    {
        public int Id { get; set; }
        public string WorkCell { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Famliy { get; set; }
        public string Model { get; set; }
        public string PartNo { get; set; }
        public string UsedFor { get; set; }
        public int UPL { get; set; }
        public string Owner { get; set; }
        public int PMPeriod { get; set; }
        public DateTime RecOn { get; set; }
        public string RecBy { get; set; }
        public DateTime EditOn { get; set; }
        public string EditBy { get; set; }
        public string RecByName { get; set; }
        public string EditByName { get; set; }
        public string OwnerName { get; set; }
    }
}