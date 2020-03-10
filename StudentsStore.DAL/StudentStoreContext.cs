using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentStore.Data.Entities;

namespace StudentStore.DAL
{
    public class StudentStoreContext : IdentityDbContext<User>
    {
        private readonly IConfiguration _config;

        public StudentStoreContext()
        {

        }

        public StudentStoreContext(DbContextOptions<StudentStoreContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
            Database.EnsureCreated();
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if MIGRATION
            optionsBuilder.UseSqlServer("data source=DESKTOP-OP1RP66\\SQLEXPRESS;initial catalog=StudentsStore;integrated security=True;MultipleActiveResultSets=True;");
#else
            optionsBuilder.UseSqlServer(_config.GetConnectionString("TotalJournalConnection"), opt => opt.MigrationsAssembly("StudentStore.DAL"));
#endif
        }
         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SubjectGroup>().HasKey(k => new { k.SubjectId, k.GroupId });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasData(new List<Student>
                {
                    new Student() { Id = "436001", FirstName = "Катерина", LastName = "Андрющенко", MiddleName = "Сергеевна", GroupId = "641п", },
                    new Student() { Id = "436002", FirstName = "Денис", LastName = "Билецкий", MiddleName = "Романович", GroupId = "641п" },
                    new Student() { Id = "436003", FirstName = "Илья", LastName = "Вирич", MiddleName = "Васильевич", GroupId = "641п" },
                    new Student() { Id = "436004", FirstName = "Роман", LastName = "Гайдук", MiddleName = "Валерьевич", GroupId = "641п" },
                    new Student() { Id = "436005", FirstName = "Борис", LastName = "Головкин", MiddleName = "Анатольевич", GroupId = "641п" },
                    new Student() { Id = "436006", FirstName = "Артур", LastName = "Гулеватый", MiddleName = "Игоревич", GroupId = "641п" },
                    new Student() { Id = "436007", FirstName = "Виталий", LastName = "Дворник", MiddleName = "Юрьевич", GroupId = "641п" },
                    new Student() { Id = "436008", FirstName = "Михаил", LastName = "Дронов", MiddleName = "Эдуардович", GroupId = "641п" },
                    new Student() { Id = "436009", FirstName = "Владислав", LastName = "Колесник", MiddleName = "Юрьевич", GroupId = "631пст" },
                    new Student() { Id = "436010", FirstName = "Артем", LastName = "Мирошниченко", MiddleName = "Валерьевич", GroupId = "631пст" },
                    new Student() { Id = "436011", FirstName = "Евгений", LastName = "Могилевский", MiddleName = "Романович", GroupId = "631пст" },
                    new Student() { Id = "436012", FirstName = "Катерина", LastName = "Плитник", MiddleName = "Витальевна", GroupId = "631пст" },
                    new Student() { Id = "436013", FirstName = "Вадим", LastName = "Рачков", MiddleName = "Сергеевич", GroupId = "641п" },
                    new Student() { Id = "436014", FirstName = "Дмитрий", LastName = "Руденок", MiddleName = "Юрьевич", GroupId = "641п" },
                    new Student() { Id = "436015", FirstName = "Оксана", LastName = "Ткаченко", MiddleName = "Витальевна", GroupId = "642п" },
                    new Student() { Id = "436016", FirstName = "Артем", LastName = "Чуглазов", MiddleName = "Васильевич", GroupId = "642п" },
                    new Student() { Id = "436017", FirstName = "Ростислав", LastName = "Шурухин", MiddleName = "Юрьевич", GroupId = "642п" },
                    new Student() { Id = "436018", FirstName = "Александр", LastName = "Яценко", MiddleName = "Сергеевич", GroupId = "642п" },
                    new Student() { Id = "436019", FirstName = "Евгений", LastName = "Виноградный", MiddleName = "Олегович", GroupId = "642п" },
                    new Student() { Id = "436020", FirstName = "Валерий", LastName = "Глянцев", MiddleName = "Олегович", GroupId = "642п" },
                    new Student() { Id = "436021", FirstName = "Диана", LastName = "Грушко", MiddleName = "Александровна", GroupId = "642п" },

                });                
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasData(
                    new List<Group>()
                    {
                        new Group{ Id = "611п", CourseNumber = 1 },
                        new Group{ Id = "612п", CourseNumber = 1},
                        new Group{ Id = "621п", CourseNumber = 2},
                        new Group{ Id = "622п", CourseNumber = 2},
                        new Group{ Id = "611пст", CourseNumber = 2},
                        new Group{ Id = "631п", CourseNumber = 3},
                        new Group{ Id = "632п", CourseNumber = 3},
                        new Group{ Id = "621пст", CourseNumber = 3},
                        new Group{ Id = "641п", CourseNumber = 4},
                        new Group{ Id = "642п", CourseNumber = 4 } ,
                        new Group{ Id = "631пст", CourseNumber = 4 }
                    });
            });
        }
           
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
