using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.Data.Models;


namespace ConstructPC.ViewModels
{
    public class CasesBoxListViewModel
    {
        public IEnumerable<CaseBox> allcases { get; set; }
        public string caseboxCategory { get; set; }
    }
}
