using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockRAMMemory : IAllRAMMemorys
    {
        public IEnumerable<RAMMemory> Rmemory
        {
            get
            {
                return new List<RAMMemory> {
                    new RAMMemory{id=0, type="DDR4", memory= 4, frequency = 3200, img= "/img/1RAM DDR4.jpg"},
                    new RAMMemory{id=1, type="DDR4", memory= 8, frequency = 3200, img= "/img/1RAM DDR4.jpg"},
                    new RAMMemory{id=2, type="DDR4", memory= 16, frequency = 3200, img= "/img/1RAM DDR4.jpg"},
                    new RAMMemory{id=3, type="DDR4", memory= 32, frequency = 3200, img= "/img/2RAM DDR4.jpg"},
                    new RAMMemory{id=4, type="DDR4", memory= 64, frequency = 3200, img= "/img/2RAM DDR4.jpg"},
                    new RAMMemory{id=5, type="DDR4", memory= 128, frequency = 3200, img= "/img/2RAM DDR4.jpg"},
                    new RAMMemory{id=6, type="DDR4", memory= 4, frequency = 2400, img= "/img/1RAM DDR4.jpg"},
                    new RAMMemory{id=7, type="DDR4", memory= 8, frequency = 2400, img= "/img/1RAM DDR4.jpg"},
                    new RAMMemory{id=8, type="DDR4", memory= 16, frequency = 2400, img= "/img/1RAM DDR4.jpg"},
                    new RAMMemory{id=9, type="DDR4", memory= 32, frequency = 2400, img= "/img/2RAM DDR4.jpg"},
                    new RAMMemory{id=10, type="DDR4", memory= 64, frequency = 2400, img= "/img/2RAM DDR4.jpg"},
                    new RAMMemory{id=11, type="DDR4", memory= 128, frequency = 2400, img= "/img/2RAM DDR4.jpg"},
                    new RAMMemory{id=12, type="DDR5", memory= 4, frequency = 3200, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=13, type="DDR5", memory= 8, frequency = 3200, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=14, type="DDR5", memory= 16, frequency = 3200, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=15, type="DDR5", memory= 32, frequency = 3200, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=16, type="DDR5", memory= 64, frequency = 3200, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=17, type="DDR5", memory= 128, frequency = 3200, img= "/img/2RAM DDR5.jpg"},                  
                    new RAMMemory{id=18, type="DDR5", memory= 4, frequency = 2400, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=19, type="DDR5", memory= 8, frequency = 2400, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=20, type="DDR5", memory= 16, frequency = 2400, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=21, type="DDR5", memory= 32, frequency = 2400, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=22, type="DDR5", memory= 64, frequency = 2400, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=23, type="DDR5", memory= 128, frequency = 2400, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=24, type="DDR5", memory= 4, frequency = 3600, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=25, type="DDR5", memory= 8, frequency = 3600, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=26, type="DDR5", memory= 16, frequency = 3600, img= "/img/1RAM DDR5.jpg"},
                    new RAMMemory{id=27, type="DDR5", memory= 32, frequency = 3600, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=28, type="DDR5", memory= 64, frequency = 3600, img= "/img/2RAM DDR5.jpg"},
                    new RAMMemory{id=29, type="DDR5", memory= 128, frequency = 3600, img= "/img/2RAM DDR5.jpg"}

                };
            }
        }

        public RAMMemory getobjectRmemory(int Rmemoryid)
        {
            throw new NotImplementedException();
        }
    }
}
