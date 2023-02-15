using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class ProcessorRepository : IAllProcessors
    {
        private readonly AppDBContent appDBContent;
        public ProcessorRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        const string V = "AMD";

        public IEnumerable<Processor> Processors => appDBContent.Processor;

        public IEnumerable<Processor> ProcAMD => throw new NotImplementedException();

        public Processor getobjectprocessor(int Processorid) => appDBContent.Processor.FirstOrDefault(p => p.id == Processorid);
        
    }
}
