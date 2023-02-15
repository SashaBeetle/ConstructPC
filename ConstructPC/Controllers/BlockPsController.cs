using ConstructPC.Data.Interfaces;
using ConstructPC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Controllers
{
    public class BlockPsController:Controller
    {
        private readonly IAllBlockPs _allblockPs;

        public BlockPsController(IAllBlockPs iallblockPs)
        {
            _allblockPs = iallblockPs;
        }

        public ViewResult BlockPsList()
        {
            ViewBag.Title = "Сторінка з БЖ";
            BlockPsListModel obj = new BlockPsListModel();
            obj.allblockPs = _allblockPs.BlockPs;
            obj.blockpCategory = "Блоки Живлення";
            return View(obj);
        }
    }
}
