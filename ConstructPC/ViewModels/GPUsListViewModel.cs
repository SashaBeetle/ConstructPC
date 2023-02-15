using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.Data.Models;

namespace ConstructPC.ViewModels
{
    public class GPUsListViewModel
    {
        public IEnumerable<GPU> allgpus { get; set; }
        public string gpuCategory { get; set; }
    }
}
