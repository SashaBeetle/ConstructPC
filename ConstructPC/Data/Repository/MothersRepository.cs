using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Repository
{
    public class MothersRepository : IAllMotherboards
    {
        private readonly AppDBContent appDBContent;
        public MothersRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }




        public IEnumerable<Motherboard> Motherboards => appDBContent.Motherboard;
        public IEnumerable<Motherboard> getFavMotherboard => appDBContent.Motherboard.Where(p => p.isFavorite);

        public IEnumerable<Motherboard> INTELmotherboards => appDBContent.Motherboard.Where(p => p.isFavorite);

        public IEnumerable<Motherboard> AMDmotherboards => appDBContent.Motherboard.Where(s => s.producer == "AMD");

        public Motherboard getobjectMotherboard(int Motherid) => appDBContent.Motherboard.FirstOrDefault(p => p.id == Motherid);
        
    }
}
