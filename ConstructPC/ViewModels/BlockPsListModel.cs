using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConstructPC.Data.Models;


namespace ConstructPC.ViewModels
{
    public class BlockPsListModel
    {
        public IEnumerable<BlockP> allblockPs { get; set; }
        public string blockpCategory { get; set; }
    }
}
