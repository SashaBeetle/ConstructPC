using ConstructPC.Data.Interfaces;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class GPUsController: Controller
    {
        private readonly IAllGPUs _allgpus;

        public GPUsController(IAllGPUs iallgpus)
        {
            _allgpus = iallgpus;
        }

        public ViewResult GPUsList()
        {
            ViewBag.Title = "Сторінка з Відеокартами";
            GPUsListViewModel obj = new GPUsListViewModel();
            obj.allgpus = _allgpus.GPUs;
            obj.gpuCategory = "Відеокарти";
            return View(obj);
        }
    }
}
