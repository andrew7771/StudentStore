using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using StudentStore.DAL;
using StudentStore.DAL.Entities;
using StudentStore.Repositories.Implementation;
using StudentStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStore.Infrastructure
{
    public static class ServicesConfigurator
    {
        public static void AddProjectDatadaseConfiguration(this IServiceCollection services)
        {
            services.AddDbContext<StudentStoreContext>();
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<StudentStoreContext>();
        }

        public static void AddProjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
        }
    }
}
