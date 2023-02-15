using Microsoft.AspNetCore.Mvc;
using ConstructPC.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using ConstructPC.ViewModels;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class RAMMemorysController:Controller
    {
        private readonly IAllRAMMemorys _allrammemorys;

        public RAMMemorysController(IAllRAMMemorys iallrammemorys)
        {
            _allrammemorys = iallrammemorys;
        }

        public ViewResult RAMMemorysList()
        {
            ViewBag.Title = "Сторінка з ОЗП";
            RAMMemorysListViewModel obj = new RAMMemorysListViewModel();
            obj.allRmemory = _allrammemorys.Rmemory;
            obj.RmemoryCategory = "Оперативна пам'ять";
            return View(obj);
        }
    }
}
