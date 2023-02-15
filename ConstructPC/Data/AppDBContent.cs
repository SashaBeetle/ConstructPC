using ConstructPC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructPC.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options):base(options)
        {

        }

        public DbSet<Motherboard> Motherboard { get; set; }
        public DbSet<Processor> Processor { get; set; }
        public DbSet<PCBuilderItem> pcBuilderItems { get; set; }
        public DbSet<BlockP> BlockP { get; set; }
        public DbSet<CaseBox> Case { get; set; }
        public DbSet<Cooling> Cooling { get; set; }
        public DbSet<DriveMemory> DriveMemory { get; set; }
        public DbSet<GPU> GPU { get; set; }
        public DbSet<RAMMemory> RAMMemory { get; set; }
        public DbSet<PC> PC { get; set; }
        public DbSet<PCDetails> PCDetails { get; set; }



    }
}
