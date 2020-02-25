using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StudentStore.DAL
{
    class StudentStoreContextFactory : IDesignTimeDbContextFactory<StudentStoreContext>
    {
        public StudentStoreContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            return new StudentStoreContext(new DbContextOptionsBuilder<StudentStoreContext>().Options, config);
        }
    }
}
