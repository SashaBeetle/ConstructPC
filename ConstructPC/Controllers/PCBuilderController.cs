using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using ConstructPC.Data;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConstructPC.Controllers
{
    public class PCBuilderController : Controller
    {

        private readonly IAllMotherboards _motherRep;
        private readonly IAllBlockPs _blockP;
        private readonly IAllCases _casesP;
        private readonly IAllCoolings _coolingsRep;
        private readonly IAllDriveMemorys _drivememorysRep;
        private readonly IAllGPUs _gpuRep;
        private readonly IAllProcessors _processorsRep;
        private readonly IAllRAMMemorys _rammemoryRep;

        private AppDBContent _appDBContent;
        private readonly PCBuilder _builder;
        
       
        public PCBuilderController(IAllMotherboards mother, PCBuilder builder, IAllCases cases, IAllBlockPs blockP, IAllCoolings coolings, IAllDriveMemorys drivememory, IAllGPUs gpu, IAllProcessors processors, IAllRAMMemorys rammemory, AppDBContent appDBContent)
        {
            _motherRep = mother;
            _builder = builder;
            _rammemoryRep = rammemory;
            _casesP = cases;
            _coolingsRep = coolings;
            _blockP = blockP;
            _drivememorysRep = drivememory;
            _gpuRep = gpu;
            _processorsRep = processors;
            _appDBContent = appDBContent;
        }

 
        public RedirectToActionResult addtobuild(int id)
        {
            var item = _motherRep.Motherboards.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _builder.AddtoBuilder(item);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Index()
        {
            PcBuilderViewModel obj = new PcBuilderViewModel();
            obj.allmothers = _motherRep.Motherboards;
            return View(obj);
        }
        [HttpPost]
        
        public  async Task<IActionResult> Index(PcBuilderViewModel model)
        {
            PcBuilderViewModel obj = new PcBuilderViewModel();
            obj.allprocessors = _processorsRep.Processors;
            if(model.processor == "AMD")
            {
                foreach (Processor proc in obj.allprocessors) { 
                
                }
                
            }
            return View();
        }
        
    }
}
