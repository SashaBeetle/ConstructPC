using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    public class GPU
    {
        public int id { set; get; }
        public string producer { set; get; }
        public string model { set; get; }
        public int voltage { set; get; }
        public string img { set; get; }
        public int memory { set; get; }

    }
}
