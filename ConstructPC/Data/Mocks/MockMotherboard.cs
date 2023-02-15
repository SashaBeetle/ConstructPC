using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Mocks
{
    public class MockMotherboard : IAllMotherboards
    {
        public IEnumerable<Motherboard> Motherboards{

            get {
                return new List<Motherboard> {
                    //new Motherboard{ producer = "AMD", socket = "AM4", name ="Gigabyte Aorus Elite" , memory = 128, typeMemory="DDR4", img = "/img/Mothers/AM4_Giga.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM4", name ="MSI Gaming Plus Max" , memory = 64,typeMemory="DDR4", img = "/img/Mothers/AM4_MSI.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM4", name ="Asus ROG Strix" , memory = 128,typeMemory="DDR4", img = "/img/Mothers/AM4_Asus.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM4", name ="Asus TUF Gaming" , memory = 128,typeMemory="DDR4", img = "/img/Mothers/AM4_AsusTuf.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{producer = "AMD", socket = "AM4", name ="Asus TUF Gaming" , memory = 128,typeMemory="DDR4", img = "/img/Mothers/AM4Micri_Tuf.png", isFavorite = true, formfactor="Micro-ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM5", name ="Gigabyte Aorus Elite AX" , memory = 128,typeMemory="DDR4", img = "/img/Mothers/AM5_GigaAx.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM5", name ="Asus ROG STRIX" , memory = 128,typeMemory="DDR5", img = "/img/Mothers/AM5_Asus.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM5", name ="MSI Carbon", memory = 128,typeMemory="DDR5", img = "/img/Mothers/AM5_MSI.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "AM5", name ="Gigabyte DS3H" , memory = 128,typeMemory="DDR5", img = "/img/Mothers/AM5micro_giga.jpg", isFavorite = true, formfactor="Micro-ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "sTRX4", name ="ASUS ROG ZENITH II" , memory = 128, typeMemory="DDR4", img = "/img/Mothers/sTRX4_Asus.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "sTRX4", name ="MSI Pro" , memory = 128,typeMemory="DDR4", img = "/img/Mothers/sTRX4_Msi.png", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "TR4", name ="ASUS ROG STRIX GAMING" , memory = 256,typeMemory="DDR4", img = "/img/Mothers/TR4_Asus.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "AMD", socket = "TR4", name ="ASRock Phantom Gaming" , memory = 128,typeMemory="DDR4", img = "/img/Mothers/TR4_Asrock.jpg", isFavorite = true, formfactor="ATX", SlotM2 = true},
                    ////
                    //new Motherboard{ producer = "Intel", socket = "1151",name ="ASUS Prime", memory = 64, typeMemory="DDR4",img = "/img/Mothers/1151_Asus.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1151",name ="Asus Strix Gaming", memory = 64, typeMemory="DDR4",img = "/img/Mothers/1151_AsusStrix.jpg", isFavorite = false, formfactor="ATX", SlotM2 = false},
                    //new Motherboard{ producer = "Intel", socket = "1151",name ="GIGABYTE H", memory = 32, typeMemory="DDR4",img = "/img/Mothers/1151_Giga.jpg", isFavorite = false, formfactor="Micro-ATX", SlotM2 = false},
                    //new Motherboard{ producer = "Intel", socket = "1151",name ="MSI Pro-VDH", memory = 32, typeMemory="DDR4",img = "/img/Mothers/1151_MSI.jpg", isFavorite = false, formfactor="Micro-ATX", SlotM2 = false},
                    //new Motherboard{ producer = "Intel", socket = "1200",name ="Asus Prime Plus", memory = 128, typeMemory="DDR4",img = "/img/Mothers/1200_Asus.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1200",name ="Gigabyte Aorus Xtreme", memory = 128, typeMemory="DDR4",img = "/img/Mothers/1200_Giga.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1200",name ="MSI MEG Unify", memory = 128, typeMemory="DDR4",img = "/img/Mothers/AM5_MSI.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1700",name ="Asus TUF Gaming", memory = 128, typeMemory="DDR4",img = "/img/Mothers/1700_AsusTuf.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1700",name ="MSI Pro", memory = 128, typeMemory="DDR4",img = "/img/Mothers/1700_Msi.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1700",name ="Gigabyte Aorus Master", memory = 128, typeMemory="DDR5",img = "/img/Mothers/1700_Giga.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "1700",name ="Asus PRIME A", memory = 128, typeMemory="DDR5",img = "/img/Mothers/1700_AsusPrime.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{ producer = "Intel", socket = "2066",name ="Asus Prime II", memory = 256, typeMemory="DDR4",img = "/img/Mothers/2066_Asus.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true},
                    //new Motherboard{producer = "Intel", socket = "2066",name ="Gigabyte UD4 Pro", memory = 512, typeMemory="DDR4",img = "/img/Mothers/2066_Giga.jpg", isFavorite = false, formfactor="ATX", SlotM2 = true}

                };
            }
        }    
        
        
        public IEnumerable<Motherboard> getFavMotherboard { get ; set ;}

        public IEnumerable<Motherboard> AMDmotherboards => throw new NotImplementedException();

        public IEnumerable<Motherboard> INTELmotherboards => throw new NotImplementedException();

        public Motherboard getobjectMotherboard(int Motherid)
        {
            throw new NotImplementedException();
        }
    }
} 
