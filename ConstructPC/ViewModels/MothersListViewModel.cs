using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.ViewModels
{
    public class MothersListViewModel
    {
        public IEnumerable<Motherboard> allmothers { get; set; }
        public IEnumerable<Motherboard> amdmothers { get; set; }

        public string motherCategory { get; set; }
    }
}
