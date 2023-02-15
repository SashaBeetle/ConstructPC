using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Interfaces
{
    public interface IAllRAMMemorys
    {
        IEnumerable<RAMMemory> Rmemory { get; }
        RAMMemory getobjectRmemory(int Rmemoryid);
    }
}
