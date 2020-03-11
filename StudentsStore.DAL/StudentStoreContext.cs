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

            modelBuilder.Entity<Subject>(entity =>
            {
                //entity.HasData(
                //    new List<Subject>()
                //    {
                //        new Subject() { Id = 1, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 1, TeacherID=8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 2, SubjectName = "Основы программной инженерии", SubjectType = SubjectType.Exam, Term = 1, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 3, SubjectName = "Компьтерная дискретная математика", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 4, SubjectName = "Основы программирования", SubjectType = SubjectType.Exam, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 5, SubjectName = "Групповая динамика и коммуникации", SubjectType = SubjectType.Credit, Term = 2, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 6, SubjectName = "Дискретные структуры", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 7, SubjectName = "Человеко-машинное взаимодействие", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 8, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 9, SubjectName = "Теория вероятности и математическая статистика", SubjectType = SubjectType.Exam, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 10, SubjectName = "Профессиональная практика программной инженерии", SubjectType = SubjectType.Credit, Term = 3, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 11, SubjectName = "Алгоритмы и структуры данных", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 12, SubjectName = "Архитектура ЭОМ", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() {}  },
                //        new Subject() { Id = 13, SubjectName = "Эмперические методы программной инженерии", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 14, SubjectName = "Конструирование программного обеспечения", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 15, SubjectName = "Организация компьтерных сетей", SubjectType = SubjectType.Exam, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 16, SubjectName = "Объектно-ориентированное программирование", SubjectType = SubjectType.Credit, Term = 4, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 17, SubjectName = "Инженерная и компьютерная графика", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 18, SubjectName = "Анализ требований к программному обеспечению", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 19, SubjectName = "Операционные системы", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 20, SubjectName = "Качество ПО и тестирование", SubjectType = SubjectType.Exam, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 21, SubjectName = "Английский язык", SubjectType = SubjectType.Credit, Term = 5, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 22, SubjectName = "Архитектура и проектирование ПО", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 23, SubjectName = "Базы данных", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 24, SubjectName = "Методы оптимизации и исследования операций", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 25, SubjectName = "Программирование интернет", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 26, SubjectName = "Системы искусственного интелекта", SubjectType = SubjectType.Exam, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 27, SubjectName = "Android", SubjectType = SubjectType.Credit, Term = 6, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 28, SubjectName = "Информационные технологии разработки ПО", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 29, SubjectName = "Безопасность программ и данных", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>()},
                //        new Subject() { Id = 30, SubjectName = "Проектирование распределенных систем ЭОМ", SubjectType = SubjectType.Exam, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 31, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 7, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 32, SubjectName = "Менеджмент проектов ПО", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 33, SubjectName = "Проектирование производственных экспертных систем", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 34, SubjectName = "Международные стандарты программной инженерии", SubjectType = SubjectType.Exam, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>() },
                //        new Subject() { Id = 35, SubjectName = "Проектный практикум", SubjectType = SubjectType.Credit, Term = 8, TeacherID = 8, /*Students = new List<Student>()*/ Groups = new List<Group>()}
                //    });
            });
        }
           
        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
