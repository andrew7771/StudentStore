using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentStore.Repositories.Implementation;
using StudentStore.Repositories.Interfaces;
using StudentStore.BLL.Services.Implementation;
using StudentStore.BLL.Services.Interfaces;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Configuration;
using Swashbuckle.AspNetCore.SwaggerUI;
using StudentStore.DAL;
using StudentStore.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using StudentStore.Infrastructure;
using Swashbuckle.AspNetCore.SwaggerGen;
using AutoMapper;
using StudentStore.BLL.Mappings;

namespace StudentStore
{
    public class Startup
    {        

        public void ConfigureServices(IServiceCollection services)
        {
            //var migrationAssembly = typeof(StudentStoreContext).GetTypeInfo().Assembly.GetName().Name;
            services.AddProjectMappings();
            services.AddProjectDatadaseConfiguration();
            services.AddProjectRepositories();

            services.AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(SwaggerGen);

            services.AddScoped<IStudentService, StudentService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(SwaggerConfigurator);

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void SwaggerGen(SwaggerGenOptions options) => options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        
        private void SwaggerConfigurator(SwaggerUIOptions options) => options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        
    }
}
