using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConstructPC.Data.Models
{
    public class PCBuilder
    {
        private readonly AppDBContent appDBContent;
        public PCBuilder(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string PCBuilderId { get; set; }
        public List<PCBuilderItem> listbuilderitems { get; set; }
        public static PCBuilder GetBuild(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string BuilderId = session.GetString("BuilderId") ?? Guid.NewGuid().ToString();

            session.SetString("BuilderId", BuilderId);
            return new PCBuilder(context) { PCBuilderId = BuilderId };
        }
        public void AddtoBuilder(Motherboard mother)
        {
            appDBContent.pcBuilderItems.Add(new PCBuilderItem
            {
                pos = PCBuilderId,
                mother = mother
            }) ;
            appDBContent.SaveChanges();
        }
        public List<PCBuilderItem> getbuilditems()
        {
            return appDBContent.pcBuilderItems.Where(c => c.pos == PCBuilderId).Include(s => s.mother).ToList();
        }
    }
}
