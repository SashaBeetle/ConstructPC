using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Interfaces
{
    public interface IAllProcessors
    {
        IEnumerable<Processor> Processors { get; }
        IEnumerable<Processor> ProcAMD { get; }

        Processor getobjectprocessor(int Processorid);
    }
}
