using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockBlockP : IAllBlockPs
    {
        public IEnumerable<BlockP> BlockPs
        {
            get
            {
                return new List<BlockP> {
                    new BlockP{name="ASUS ROG Strix", power=650, Protecttype="Gold", img="/img/AsusRogStrixBP.jpg"},
                    new BlockP{name="Be Quiet!", power=500, Protecttype="Silver", img="/img/BeQuiet500.jpg"},
                    new BlockP{ name="Aero Cool", power=500, Protecttype="Bronze", img="/img/AeroCool500.jpg"},
                    new BlockP{ name="MSI MPG", power=750, Protecttype="Gold", img="/img/MsiMpg750.jpg"},
                    new BlockP{ name="Gigabyte PGM", power=850, Protecttype="Gold", img="/img/GigabytePGM850.jpg"},
                    new BlockP{name="GameMax GP", power=850, Protecttype="Bronze", img="/img/GameMax850.jpg"},
                    new BlockP{name="Vinga VPS", power=1000, Protecttype="Gold", img="/img/VingaVPS1000.jpg"},
                    new BlockP{ name="Cougar GX", power=1050, Protecttype="Gold", img="/img/Cougar1050.jpg"},
                    new BlockP{name="Chiftec GPU", power=1200, Protecttype="Gold", img="/img/Cougar1050.jpg"},
                    new BlockP{name="Corsair AX", power=1600, Protecttype="Titanium", img="/img/CorsairAX1600.jpg"}
};
            }
        }


        public BlockP getobjectBlockPs(int BlockPid)
        {
            throw new NotImplementedException();
        }
    }
}
