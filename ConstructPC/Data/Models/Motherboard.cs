using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    [Table("Motherboard")]
    public class Motherboard
    {
        [Key]
        public int id { set; get; }
        public string name { set; get; }
        public bool isFavorite { set; get; }
        public string producer { set; get; }
        public string socket { set; get; }
        public string formfactor { set; get; }
        public string img { set; get; }
        public int memory { set; get; }
        public string typeMemory { get; set; }
        public bool SlotM2 { set; get; }
    }
}

