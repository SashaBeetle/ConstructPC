using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Motherboard> favmotherboards { get; set; }
        public IEnumerable<Motherboard> allmothers { get; set; }
    }
}
