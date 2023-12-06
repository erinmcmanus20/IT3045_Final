using IT3045_Final.Data;
using IT3045_Final.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace IT3045_Final
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration {get;}
        public TeamMemberContext context {get;}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSwaggerDocument();
            services.AddMvc(options => options.EnableEndpointRouting = false);

            services.AddDbContext<TeamMemberContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TeamMemberContext"),
                options => options.EnableRetryOnFailure()));
            services.AddScoped<ITeamMemberContextDAO, TeamMemberContextDAO>();   

            services.AddDbContext<BookContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BookContext"),
            options => options.EnableRetryOnFailure()));

            services.AddControllers(); 
            services.AddScoped<IBookContextDAO, BookContextDAO>();

             services.AddDbContext<BaseballTeamContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BaseballTeamContext"),
                options => options.EnableRetryOnFailure()));
            services.AddScoped<IBaseballTeamContextDAO, BaseballTeamContextDAO>();  

            services.AddDbContext<SportsContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SportsContext"),
                options => options.EnableRetryOnFailure()));
            services.AddScoped<ISportsContextDAO, SportsContextDAO>();   
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            //context.Database.Migrate();
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TeamMemberContext>();
                context.Database.Migrate();
            }

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var bookContext = serviceScope.ServiceProvider.GetService<BookContext>();
                bookContext.Database.Migrate();
            }

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var baseballteamcontext = serviceScope.ServiceProvider.GetService<BaseballTeamContext>();
                context.Database.Migrate();
            }

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var sportsContext = serviceScope.ServiceProvider.GetService<SportsContext>();
                sportsContext.Database.Migrate();
            }

            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseMvc();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
            });


   
            
        }
    }
}
