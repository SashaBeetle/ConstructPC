using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class DriveMemorysRepository:IAllDriveMemorys
    {
        private readonly AppDBContent appDBContent;
        public DriveMemorysRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<DriveMemory> DMemorys => appDBContent.DriveMemory;


        public DriveMemory getobjectDMemorys(int DMemoryid)=>appDBContent.DriveMemory.FirstOrDefault(p => p.id == DMemoryid);
        
    }
}
