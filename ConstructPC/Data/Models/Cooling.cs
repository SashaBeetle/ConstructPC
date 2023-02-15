using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    public class Cooling
    {
        public int id { set; get; }
        public string name { set; get; }
        public string type { set; get; }
        public string img { set; get; }
        public int TDP { set; get; }
    }
}
