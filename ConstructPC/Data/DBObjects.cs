using ConstructPC.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data
{
    public class DBObjects
    {
        public static void initial(AppDBContent content)
        {


        //    if (!content.Motherboard.Any())
        //        content.Motherboard.AddRange(Mothers.Select(c => c.Value));

        //    if (!content.GPU.Any())
        //        content.GPU.AddRange(GPSs.Select(c => c.Value));

        //    //if (!content.Motherboard.Any())
        //    //{

        //    //    content.AddRange(
        //    //      new Motherboard { producer = "AMD", socket = "AM4", name = "Gigabyte Aorus EliteMonster", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4_Giga.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "AMD", socket = "AM4", name = "MSI Gaming Plus Max", memory = 64, typeMemory = "DDR4", img = "/img/Mothers/AM4_MSI.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "AMD", socket = "AM4", name = "Asus ROG Strix", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "AMD", socket = "AM4", name = "Asus TUF Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4_AsusTuf.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "AMD", socket = "AM4", name = "Asus TUF Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4Micri_Tuf.png", isFavorite = true, formfactor = "Micro-ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "AMD", socket = "AM5", name = "Gigabyte Aorus Elite AX", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM5_GigaAx.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "AMD", socket = "AM5", name = "Asus ROG STRIX", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/AM5_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "AMD", socket = "AM5", name = "MSI Carbon", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/AM5_MSI.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "AMD", socket = "AM5", name = "Gigabyte DS3H", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/AM5micro_giga.jpg", isFavorite = true, formfactor = "Micro-ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "AMD", socket = "sTRX4", name = "ASUS ROG ZENITH II", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/sTRX4_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "AMD", socket = "sTRX4", name = "MSI Pro", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/sTRX4_Msi.png", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "AMD", socket = "TR4", name = "ASUS ROG STRIX GAMING", memory = 256, typeMemory = "DDR4", img = "/img/Mothers/TR4_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "AMD", socket = "TR4", name = "ASRock Phantom Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/TR4_Asrock.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //    //        //
        //    //        new Motherboard {  producer = "Intel", socket = "1151", name = "ASUS Prime", memory = 64, typeMemory = "DDR4", img = "/img/Mothers/1151_Asus.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "1151", name = "Asus Strix Gaming", memory = 64, typeMemory = "DDR4", img = "/img/Mothers/1151_AsusStrix.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = false },
        //    //        new Motherboard {  producer = "Intel", socket = "1151", name = "GIGABYTE H", memory = 32, typeMemory = "DDR4", img = "/img/Mothers/1151_Giga.jpg", isFavorite = false, formfactor = "Micro-ATX", SlotM2 = false },
        //    //        new Motherboard {  producer = "Intel", socket = "1151", name = "MSI Pro-VDH", memory = 32, typeMemory = "DDR4", img = "/img/Mothers/1151_MSI.jpg", isFavorite = false, formfactor = "Micro-ATX", SlotM2 = false },
        //    //        new Motherboard {  producer = "Intel", socket = "1200", name = "Asus Prime Plus", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1200_Asus.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "1200", name = "Gigabyte Aorus Xtreme", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1200_Giga.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "Intel", socket = "1200", name = "MSI MEG Unify", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM5_MSI.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "1700", name = "Asus TUF Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1700_AsusTuf.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "1700", name = "MSI Pro", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1700_Msi.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard { producer = "Intel", socket = "1700", name = "Gigabyte Aorus Master", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/1700_Giga.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "1700", name = "Asus PRIME A", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/1700_AsusPrime.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "2066", name = "Asus Prime II", memory = 256, typeMemory = "DDR4", img = "/img/Mothers/2066_Asus.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //    //        new Motherboard {  producer = "Intel", socket = "2066", name = "Gigabyte UD4 Pro", memory = 512, typeMemory = "DDR4", img = "/img/Mothers/2066_Giga.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true }
        //    //    );

        //    //}

        //    //content.SaveChanges();
        //}




        //private static Dictionary<string, Motherboard> motherboard;
        //public static Dictionary<string, Motherboard> Mothers
        //{
        //    get
        //    {
        //        if (motherboard == null)
        //        {
        //            var list = new Motherboard[]
        //            {
        //           new Motherboard { producer = "AMD", socket = "AM4", name = "Gigabyte Aorus Elite", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4_Giga.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "AMD", socket = "AM4", name = "MSI Gaming Plus Max", memory = 64, typeMemory = "DDR4", img = "/img/Mothers/AM4_MSI.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "AMD", socket = "AM4", name = "Asus ROG Strix", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "AMD", socket = "AM4", name = "Asus TUF Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4_AsusTuf.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "AMD", socket = "AM4", name = "Asus TUFm Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM4Micri_Tuf.png", isFavorite = true, formfactor = "Micro-ATX", SlotM2 = true },
        //            new Motherboard {producer = "AMD", socket = "AM5", name = "Gigabyte Aorus Elite AX", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM5_GigaAx.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "AMD", socket = "AM5", name = "Asus ROG STRIX", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/AM5_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "AMD", socket = "AM5", name = "MSI Carbon", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/AM5_MSI.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "AMD", socket = "AM5", name = "Gigabyte DS3H", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/AM5micro_giga.jpg", isFavorite = true, formfactor = "Micro-ATX", SlotM2 = true },
        //            new Motherboard {  producer = "AMD", socket = "sTRX4", name = "ASUS ROG ZENITH II", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/sTRX4_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "AMD", socket = "sTRX4", name = "MSI Pro", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/sTRX4_Msi.png", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "AMD", socket = "TR4", name = "ASUS ROG STRIX GAMING", memory = 256, typeMemory = "DDR4", img = "/img/Mothers/TR4_Asus.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "AMD", socket = "TR4", name = "ASRock Phantom Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/TR4_Asrock.jpg", isFavorite = true, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "1151", name = "ASUS Prime", memory = 64, typeMemory = "DDR4", img = "/img/Mothers/1151_Asus.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "1151", name = "Asus Strix Gaming", memory = 64, typeMemory = "DDR4", img = "/img/Mothers/1151_AsusStrix.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = false },
        //            new Motherboard {  producer = "Intel", socket = "1151", name = "GIGABYTE H", memory = 32, typeMemory = "DDR4", img = "/img/Mothers/1151_Giga.jpg", isFavorite = false, formfactor = "Micro-ATX", SlotM2 = false },
        //            new Motherboard { producer = "Intel", socket = "1151", name = "MSI Pro-VDH", memory = 32, typeMemory = "DDR4", img = "/img/Mothers/1151_MSI.jpg", isFavorite = false, formfactor = "Micro-ATX", SlotM2 = false },
        //            new Motherboard { producer = "Intel", socket = "1200", name = "Asus Prime Plus", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1200_Asus.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "Intel", socket = "1200", name = "Gigabyte Aorus Xtreme", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1200_Giga.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "1200", name = "MSI MEG Unify", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/AM5_MSI.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "Intel", socket = "1700", name = "TUF Asus Gaming", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1700_AsusTuf.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard { producer = "Intel", socket = "1700", name = "MSI  Pro", memory = 128, typeMemory = "DDR4", img = "/img/Mothers/1700_Msi.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "1700", name = "Gigabyte Aorus Master", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/1700_Giga.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "1700", name = "Asus PRIME A", memory = 128, typeMemory = "DDR5", img = "/img/Mothers/1700_AsusPrime.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "2066", name = "Asus Prime II", memory = 256, typeMemory = "DDR4", img = "/img/Mothers/2066_Asus.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true },
        //            new Motherboard {  producer = "Intel", socket = "2066", name = "Gigabyte UD4 Pro", memory = 512, typeMemory = "DDR4", img = "/img/Mothers/2066_Giga.jpg", isFavorite = false, formfactor = "ATX", SlotM2 = true }

        //            };
        //            motherboard = new Dictionary<string, Motherboard>();
        //            foreach (Motherboard el in list)
        //                motherboard.Add(el.name, el);

        //        }
        //        return motherboard;
        //    }
        //}

        //private static Dictionary<string, GPU> gpu;
        //public static Dictionary<string, GPU> GPSs
        //{
        //    get
        //    {
        //        if (gpu == null)
        //        {
        //            var list = new GPU[]
        //            {
        //           new GPU{ producer = "Radeon", model="RX 7900XT", memory=20, voltage= 300, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 7900XTX", memory=24, voltage= 355, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6600", memory=8, voltage= 120, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6600XT", memory=8, voltage= 160, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6900XT", memory=16, voltage= 300, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6800XT", memory=16, voltage= 300, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6800", memory=16, voltage= 250, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6700XT", memory=12, voltage= 230, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 6500XT", memory=4, voltage= 100, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 5700XT", memory=8, voltage= 225, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 5700", memory=8, voltage= 160, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 5600XT", memory=6, voltage= 150, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 5504XT", memory=4, voltage= 130, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 5508XT", memory=8, voltage= 120, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 590", memory=8, voltage= 175, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 588", memory=8, voltage= 185, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 584", memory=4, voltage= 185, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 578", memory=8, voltage= 150, img="/img/radeon.jpg"},
        //            new GPU{ producer = "Radeon", model="RX 574", memory=4, voltage= 150, img="/img/radeon.jpg"},
        //            ///
        //            new GPU{ producer = "NVIDIA", model="RTX 3090", memory=24, voltage= 350, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3080TI", memory=12, voltage= 350, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3080", memory=12, voltage= 320, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3070TI", memory=8, voltage= 290, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3070", memory=8, voltage= 220, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3060TI", memory=8, voltage= 200, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3060", memory=12, voltage= 170, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 3050", memory=8, voltage= 130, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2080TI", memory=8, voltage= 250, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2080Super", memory=24, voltage= 250, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2080", memory=8, voltage= 215, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2070Super", memory=8, voltage= 215, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2070", memory=8, voltage= 175, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2060Super", memory=8, voltage= 175, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2060 12", memory=12, voltage= 160, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 2060", memory=6, voltage= 160, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1660TI", memory=6, voltage= 125, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1660Super", memory=6, voltage= 125, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1660", memory=6, voltage= 120, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1650Super", memory=4, voltage= 100, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1080TI", memory=11, voltage= 250, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1080", memory=8, voltage= 180, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1070TI", memory=8, voltage= 180, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1070", memory=8, voltage= 150, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1066", memory=6, voltage= 120, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="GTX 1063", memory=3, voltage= 120, img="/img/nvidia.png"},
        //            new GPU{ producer = "NVIDIA", model="RTX 4090", memory=24, voltage= 450, img="/img/nvidia.png"}
        //            };
        //            gpu = new Dictionary<string, GPU>();
        //            foreach (GPU el in list)
        //                gpu.Add(el.model, el);

        //        }
        //        return gpu;
        //    }
        }
    }
}

