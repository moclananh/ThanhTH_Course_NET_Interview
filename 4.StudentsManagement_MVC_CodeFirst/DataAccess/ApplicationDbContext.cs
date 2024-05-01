using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;
using _4.StudentsManagement_MVC_CodeFirst.FluentAPIs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace _4.StudentsManagement_MVC_CodeFirst.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       // public DbSet<BaseEntities> BaseEntities { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<ClassRoomLectures> ClassRoomLectures { get; set; }
        public DbSet<ClassRoomStudents> ClassRoomStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LectureConfigure());
            modelBuilder.ApplyConfiguration(new StudentConfigure());
           // modelBuilder.ApplyConfiguration(new BaseConfigure());
            modelBuilder.ApplyConfiguration(new RoomConfigure());
            modelBuilder.ApplyConfiguration(new ClassRoomLectureConfig());
            modelBuilder.ApplyConfiguration(new ClassRoomStudentConfig());


        }

    }
}
