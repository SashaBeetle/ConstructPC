using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    [Table("Processor")]
    public class Processor
    {
        [Key]
        public int id { set; get; }
        public string name { set; get; }
        public string model { set; get; }
        public int yadra { set; get; }
        public int potoks { set; get; }
        public string producer { set; get; }
        public string socket { set; get; }
        public string img { set; get; }
        public double hhz { set; get; }
        public int TDP { get; set; }

    }
}