using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentStore
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students {get;set;}

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                    new Student { Id="1", Name="Andrii Turianskyi"},
                    new Student { Id="2", Name="Vasya Pupkin"},
                    new Student { Id="3", Name="Sergii Kovach"}
                });
        }
    }
}
