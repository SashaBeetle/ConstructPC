using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class GPUsRepository : IAllGPUs
    {
        private readonly AppDBContent appDBContent;
        public GPUsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<GPU> GPUs => appDBContent.GPU;


        public GPU getobjectGPU(int GPUid) => appDBContent.GPU.FirstOrDefault(p => p.id == GPUid);

    }
}
