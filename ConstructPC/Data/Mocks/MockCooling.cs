using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockCooling : IAllCoolings
    {
        public IEnumerable<Cooling> Coolings
        {
            get
            {
                return new List<Cooling> {
                    new Cooling {name = "Dark Rock Pro 4", type="Fan", TDP=230, img="/img/Cooling/DarkRockPro4.jpg"},
                    new Cooling{ name = "GAMMAXX 300", type="Fan", TDP=140, img="/img/Cooling/GAMMAXX300.jpg"},
                    new Cooling{name = "AS500", type="Fan", TDP=200, img="/img/Cooling/AS500.jpg"},
                    new Cooling{ name = "Archer BigPro", type="Fan", TDP=100, img="/img/Cooling/ArcherBigPro.jpg"},
                    new Cooling{ name = "CL3010", type="Fan", TDP=125, img="/img/Cooling/CL3010.jpg"},
                    new Cooling{ name = "IceHill", type="Water", TDP=200, img="/img/Cooling/IceHill.jpg"},
                    new Cooling{ name = "Liquid Freezer II", type="Water", TDP=250, img="/img/Cooling/LiquidFreezerII.jpg"},
                    new Cooling{name = "Kraken Z73", type="Water", TDP=280, img="/img/Cooling/KrakenZ73.jpg"}

};
            }
        }


        public Cooling getobjectCoolings(int Coolingid)
        {
            throw new NotImplementedException();
        }
    }
}
