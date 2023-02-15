using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data.Models
{
    [Table("CaseBox")]
    public class CaseBox
    {   
        [Key]
        public int id { set; get; }
        public string name { set; get; }
        public string formfactor { set; get; }
        public string img { set; get; }
        public int fan_s { set; get; }
}
}
