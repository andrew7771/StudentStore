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
        public  IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddProjectMappings();
            services.AddProjectDatadaseConfiguration();
            services.AddProjectRepositories();
            services.AddProjecJwt(Configuration);

            services.AddControllers()
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(SwaggerGen);

            services.AddScoped<IUserService, UserService>();
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void SwaggerGen(SwaggerGenOptions options) => options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        
        private void SwaggerConfigurator(SwaggerUIOptions options) => options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        
    }
}
