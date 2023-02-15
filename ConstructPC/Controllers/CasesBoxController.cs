using ConstructPC.Data.Interfaces;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class CasesBoxController:Controller
    {

        private readonly IAllCases _allCases;

        public CasesBoxController(IAllCases iallcases)
        {
            _allCases = iallcases;
        }

        public ViewResult CasesBoxList()
        {
            ViewBag.Title = "Сторінка з Корпусами";
            CasesBoxListViewModel obj = new CasesBoxListViewModel();
            obj.allcases = _allCases.Cases;
            obj.caseboxCategory = "Корпуса";
            return View(obj);
        }

    }
}
