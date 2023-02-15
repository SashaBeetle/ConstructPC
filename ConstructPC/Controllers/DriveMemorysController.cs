using ConstructPC.Data.Interfaces;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class DriveMemorysController:Controller
    {
        private readonly IAllDriveMemorys _allDmemorys;

        public DriveMemorysController(IAllDriveMemorys iallDmemorys)
        {
            _allDmemorys = iallDmemorys;
        }

        public ViewResult DriveMemorysList()
        {
            ViewBag.Title = "Сторінка з Накопичувачами";
            DriveMemorysListViewModel obj = new DriveMemorysListViewModel();
            obj.allDmemorys = _allDmemorys.DMemorys;
            obj.dmemoryCategory = "Накопичувачі";
            return View(obj);
        }
    }
}
