using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Interfaces
{
    public interface IAllBlockPs
    {
        IEnumerable<BlockP> BlockPs { get; }
        BlockP getobjectBlockPs(int BlockPid);
    }
}
