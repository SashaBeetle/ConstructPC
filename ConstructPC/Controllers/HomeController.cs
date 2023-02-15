using ConstructPC.Data.Interfaces;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class HomeController : Controller
    {
       
        private IAllMotherboards _motherRep;




        public HomeController(IAllMotherboards motherRep)
        {
            _motherRep = motherRep;
           
        }
        public ViewResult Index()
        {
            var homemothers = new HomeViewModel
            {
                favmotherboards = _motherRep.getFavMotherboard
            };
            return View(homemothers);
        }

    }
}
