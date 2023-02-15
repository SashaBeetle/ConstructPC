using ConstructPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ConstructPC.Controllers
{
    public class ProcessorsController : Controller
    {
        private readonly IAllProcessors _allprocessors;

        public ProcessorsController(IAllProcessors iallprocessors)
        {
            _allprocessors = iallprocessors;
        }

        public ViewResult ListProcessors()
        {
            ViewBag.Title = "Сторінка з Процесорами";
            ProcessorsViewModel obj = new ProcessorsViewModel();
            obj.allprocessors = _allprocessors.Processors;
            obj.processorCategory = "Процесори";
            return View(obj);
        }
    }
}