using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockDriveMemory : IAllDriveMemorys
    {
        public IEnumerable<DriveMemory> DMemorys
        {
            get
            {
                return new List<DriveMemory> {
                    new DriveMemory{ type="HDD", memory = 1000, model="Seagate Barracuda", img="/img/SeagateBarracuda.jpg", M2 = false},
                    new DriveMemory{ type="HDD", memory = 2000, model="Seagate Barracuda", img="/img/SeagateBarracuda.jpg", M2 = false},
                    new DriveMemory{ type="HDD", memory = 3000, model="Seagate Barracuda", img="/img/SeagateBarracuda.jpg", M2 = false},
                    new DriveMemory{ type="HDD", memory = 4000, model="Seagate Barracuda", img="/img/SeagateBarracuda.jpg", M2 = false},
                    new DriveMemory{ type="HDD", memory = 5000, model="Seagate Barracuda", img="/img/SeagateBarracuda.jpg", M2 = false},
                    new DriveMemory{ type="HDD", memory = 500, model="Seagate Barracuda", img="/img/SeagateBarracuda.jpg", M2 = false},
                    new DriveMemory{ type="SSD", memory = 120, model="Kingston", img="/img/kingstonssd.jpg", M2 = false},
                    new DriveMemory {type="SSD", memory = 240, model="Kingston", img="/img/kingstonssd.jpg", M2 = false},
                    new DriveMemory{ type="SSD", memory = 480, model="Kingston", img="/img/kingstonssd.jpg", M2 = false},
                    new DriveMemory{ type="SSD", memory = 960, model="Kingston", img="/img/kingstonssd.jpg", M2 = false},
                    new DriveMemory{ type="M2", memory = 250, model="Samsung", img="/img/SamsungM2.jpg", M2 =true},
                    new DriveMemory{ type="M2", memory = 500, model="Samsung", img="/img/SamsungM2.jpg", M2 =true},
                    new DriveMemory{ type="M2", memory = 1000, model="Samsung", img="/img/SamsungM2.jpg", M2 =true},
                    new DriveMemory{ type="M2", memory = 2000, model="Samsung", img="/img/SamsungM2.jpg", M2 =true}

};
            }
        }
           


        public DriveMemory getobjectDMemorys(int DMemoryid)
        {
            throw new NotImplementedException();
        }
    }
}
