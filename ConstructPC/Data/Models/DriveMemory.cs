using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    public class DriveMemory
    {
        public int id { set; get; }
        public string type { set; get; }
        public string model { set; get; }
        public string img { set; get; }
        public int memory { set; get; }
        public bool M2 { set; get; }
    }
}
