using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    public class PCDetails
    {
        public int id { get; set; }
        public string pcID { get; set; }
        public string motherID { get; set; }
        public virtual Motherboard motherboard  { get; set; }
        public virtual PC pc { get; set; }
    }
}
