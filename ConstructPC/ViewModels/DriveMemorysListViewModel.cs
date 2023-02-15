using System;
using System.Collections.Generic;
using System.Linq;
using ConstructPC.Data.Models;
using System.Threading.Tasks;

namespace ConstructPC.ViewModels
{
    public class DriveMemorysListViewModel
    {
        public IEnumerable<DriveMemory> allDmemorys { get; set; }
        public string dmemoryCategory { get; set; }
    }
}

