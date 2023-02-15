using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.Data.Models;

namespace ConstructPC.ViewModels
{
    public class RAMMemorysListViewModel
    {
        public IEnumerable<RAMMemory> allRmemory { get; set; }
        public string RmemoryCategory { get; set; }
    }
}
