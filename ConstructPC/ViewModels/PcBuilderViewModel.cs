using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ConstructPC.ViewModels
{
    public class PcBuilderViewModel
    {
        public PCBuilder pcbuilder { get; set; }
        public IEnumerable<Motherboard> allmothers { get; set; }
        public IEnumerable<Processor> allprocessors { get; set; }
        public string processor {get;set;}
        public IEnumerable<Motherboard> AMD { get; set; }
    }
}

