using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class BlockPsRepository : IAllBlockPs
    {
        private readonly AppDBContent appDBContent;
        public BlockPsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<BlockP> BlockPs => appDBContent.BlockP;


        public BlockP getobjectBlockPs(int BlockPid) => appDBContent.BlockP.FirstOrDefault(p => p.id == BlockPid);
       
    }
}
