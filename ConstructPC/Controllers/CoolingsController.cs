using ConstructPC.Data.Interfaces;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class CoolingsController:Controller
    {
        
            private readonly IAllCoolings _allcoolings;

            public CoolingsController(IAllCoolings iallcoolings)
            {
            _allcoolings = iallcoolings;
            }

            public ViewResult CoolingsList()
            {
                ViewBag.Title = "Сторінка з Охолодженням";
                CoolingsListViewModel obj = new CoolingsListViewModel();
                obj.allcoolings = _allcoolings.Coolings;
                obj.coolingCategory = "Кулера та Помпи";
                return View(obj);
            }
        
    }
}
