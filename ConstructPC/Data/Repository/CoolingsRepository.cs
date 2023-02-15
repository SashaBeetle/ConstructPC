using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class CoolingsRepository:IAllCoolings
    {
        private readonly AppDBContent appDBContent;
        public CoolingsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Cooling> Coolings => appDBContent.Cooling;


        public Cooling getobjectCoolings(int Coolingid)=>appDBContent.Cooling.FirstOrDefault(p => p.id == Coolingid);
        
        
    }
}
