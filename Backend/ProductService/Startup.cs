using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ProductService.DataLayer;
using System.Reflection;

namespace ProductService
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			// Register the DataLayer, among other the repositories and database healthcheck.
			services.AddDataLayer();

			services.AddMvc()
				// Include controllers from the Api assembly.
				.AddApplicationPart(Assembly.Load("ProductService.Api"))
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			// Add an endpoint for health checking.
			app.UseHealthChecks("/health");

			app.UseMvc();
		}
	}
}
