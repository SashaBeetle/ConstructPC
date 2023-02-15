using Microsoft.AspNetCore.Mvc;
using ConstructPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.ViewModels;

namespace ConstructPC.Controllers
{
    public class MothersController : Controller
    {
        private readonly IAllMotherboards _allmothers, _amdmothers;


        public MothersController(IAllMotherboards iallmothers, IAllMotherboards iamdmothers)
        {
            _allmothers = iallmothers;
            _amdmothers = iamdmothers;
        }
        
        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з Материнками";
            MothersListViewModel obj = new MothersListViewModel();
            obj.allmothers = _allmothers.Motherboards;
            obj.amdmothers = _amdmothers.AMDmotherboards;
            obj.motherCategory = "Материнські плати";
            return View(obj);
        }
    }
}
