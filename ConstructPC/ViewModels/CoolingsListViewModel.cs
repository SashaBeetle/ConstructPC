using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.Data.Models;


namespace ConstructPC.ViewModels
{
    public class CoolingsListViewModel
    {
        public IEnumerable<Cooling> allcoolings { get; set; }
        public string coolingCategory { get; set; }
    }
}

