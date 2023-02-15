using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    public class PCBuilderItem
    {
        public int id { get; set; }
        public Motherboard mother { get; set; }
        public string pos { get; set; }

    }
}
