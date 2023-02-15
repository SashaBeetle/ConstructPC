using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ConstructPC.Data.Interfaces;
using ConstructPC.Data.Mocks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ConstructPC.Data;
using ConstructPC.Data.Repository;
using ConstructPC.Data.Models;

namespace ConstructPC
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("DBsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllMotherboards, MothersRepository>();
            services.AddTransient<IAllProcessors, ProcessorRepository>();
            services.AddTransient<IAllGPUs, GPUsRepository>();
            services.AddTransient<IAllRAMMemorys, RAMMemorysRepository>();
            services.AddTransient<IAllBlockPs, BlockPsRepository>();
            services.AddTransient<IAllCases, CasesRepository>();
            services.AddTransient<IAllCoolings, CoolingsRepository>();
            services.AddTransient<IAllDriveMemorys, DriveMemorysRepository>();
            services.AddMvc();
            services.AddMvc(option => option.EnableEndpointRouting = false); 
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => PCBuilder.GetBuild(sp));
            services.AddMemoryCache();
            services.AddSession();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();



            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                DBObjects.initial(content);
            }

        }
    }

}
