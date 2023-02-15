using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.Data.Models;

namespace ConstructPC.ViewModels
{
    public class ProcessorsViewModel
    {
        public IEnumerable<Processor> allprocessors { get; set; }
        public IEnumerable<Processor> AMDprocessors { get; set; }
        public string processorCategory { get; set; }
    }
}
