using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class RAMMemorysRepository:IAllRAMMemorys
    {
        private readonly AppDBContent appDBContent;
        public RAMMemorysRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<RAMMemory> Rmemory => appDBContent.RAMMemory;


        public RAMMemory getobjectRmemory(int Rmemoryid) => appDBContent.RAMMemory.FirstOrDefault(p => p.id == Rmemoryid);

    }
}
