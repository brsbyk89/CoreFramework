using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreFramework.Business;
using CoreFramework.Business.Contracts;
using CoreFramework.Data;
using CoreFramework.Data.Contracts;
using CoreFramework.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreFramework
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddScoped<IAccountEngine, AccountEngine>();
			services.AddScoped<IAccountRepository, AccountRepository>();
			string assemblyName = typeof(Startup).Namespace;
			services.AddMvc();
			var connection = @"Server=KNETDEVSQL;Database=AtlantisDB;Trusted_Connection=True;";
			services.AddDbContext<DataContext>(options => options.UseSqlServer(connection, optionsBuilder =>
			   optionsBuilder.MigrationsAssembly(assemblyName)));
		}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

			app.UseMvcWithDefaultRoute();
		
			app.Run(async (context) =>
			{
				//await context.Response.WriteAsync("Hello World!");
			});
		}
    }
}
