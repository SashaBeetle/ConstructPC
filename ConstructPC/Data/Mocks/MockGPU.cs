using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockGPU : IAllGPUs
    {
        public IEnumerable<GPU> GPUs
        {
            get
            {
                return new List<GPU> {
                    new GPU{ producer = "Radeon", model="RX 7900XT", memory=20, voltage= 300, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 7900XTX", memory=24, voltage= 355, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6600", memory=8, voltage= 120, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6600XT", memory=8, voltage= 160, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6900XT", memory=16, voltage= 300, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6800XT", memory=16, voltage= 300, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6800", memory=16, voltage= 250, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6700XT", memory=12, voltage= 230, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 6500XT", memory=4, voltage= 100, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 5700XT", memory=8, voltage= 225, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 5700", memory=8, voltage= 160, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 5600XT", memory=6, voltage= 150, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 5500XT", memory=4, voltage= 130, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 5500XT", memory=8, voltage= 120, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 590", memory=8, voltage= 175, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 580", memory=8, voltage= 185, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 580", memory=4, voltage= 185, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 570", memory=8, voltage= 150, img="/img/radeon.jpg"},
                    new GPU{ producer = "Radeon", model="RX 570", memory=4, voltage= 150, img="/img/radeon.jpg"},
                    ///
                    new GPU{producer = "NVIDIA", model="RTX 3090", memory=24, voltage= 350, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 3080TI", memory=12, voltage= 350, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 3080", memory=12, voltage= 320, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 3070TI", memory=8, voltage= 290, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 3070", memory=8, voltage= 220, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 3060TI", memory=8, voltage= 200, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 3060", memory=12, voltage= 170, img="/img/nvidia.png"},
                    new GPU{producer = "NVIDIA", model="RTX 3050", memory=8, voltage= 130, img="/img/nvidia.png"},
                    new GPU{producer = "NVIDIA", model="RTX 2080TI", memory=24, voltage= 250, img="/img/nvidia.png"},
                    new GPU{producer = "NVIDIA", model="RTX 2080Super", memory=24, voltage= 250, img="/img/nvidia.png"},
                    new GPU{producer = "NVIDIA", model="RTX 2080", memory=8, voltage= 215, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 2070Super", memory=8, voltage= 215, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 2070", memory=8, voltage= 175, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 2060Super", memory=8, voltage= 175, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 2060", memory=12, voltage= 160, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 2060", memory=6, voltage= 160, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1660TI", memory=6, voltage= 125, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1660Super", memory=6, voltage= 125, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1660", memory=6, voltage= 120, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1650Super", memory=4, voltage= 100, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1080TI", memory=11, voltage= 250, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1080", memory=8, voltage= 180, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1070TI", memory=8, voltage= 180, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1070", memory=8, voltage= 150, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1060", memory=6, voltage= 120, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="GTX 1060", memory=3, voltage= 120, img="/img/nvidia.png"},
                    new GPU{ producer = "NVIDIA", model="RTX 4090", memory=24, voltage= 450, img="/img/nvidia.png"}








                };
            }
        }


        public GPU getobjectGPU(int GPUid)
        {
            throw new NotImplementedException();
        }
    }
}
