using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIENN.DbAccess.Framework;
using SIENN.DbAccess.Models;
using SIENN.DbAccess.TestData;
using Swashbuckle.AspNetCore.Swagger;

namespace SIENN.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "SIENN Recruitment API"
                });
            });

            services.AddMvc();

            // var connection = @"Server=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\Users\Piotr\Documents\SIENNTestDb.mdf;Integrated Security=True;Connect Timeout=30;";
            var connection = "Server=(localdb)\\mssqllocaldb;Database=SiennLocalDb;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddDbContext<SiennDbContext>(options => options.UseSqlServer(connection));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "SIENN Recruitment API v1");
            });

            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (!serviceScope.ServiceProvider.GetService<SiennDbContext>().AllMigrationsApplied())
                {
                    serviceScope.ServiceProvider.GetService<SiennDbContext>().Database.Migrate();
                    serviceScope.ServiceProvider.GetService<SiennDbContext>().SeedData();
                }
            }
        }
    }
}
