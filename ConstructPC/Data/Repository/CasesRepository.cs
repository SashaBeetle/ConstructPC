using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class CasesRepository:IAllCases
    {
        private readonly AppDBContent appDBContent;
        public CasesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<CaseBox> Cases => appDBContent.Case;


        public CaseBox getobjectCase(int Caseid) => appDBContent.Case.FirstOrDefault(p => p.id == Caseid);
        
    }
}
