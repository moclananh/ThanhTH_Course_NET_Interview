using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;

namespace _4.StudentsManagement_MVC_CodeFirst.FluentAPIs
{
    public class ClassRoomStudentConfig : IEntityTypeConfiguration<ClassRoomStudents>
    {
        public void Configure(EntityTypeBuilder<ClassRoomStudents> builder)
        {
            builder.ToTable("ClassRoomStudents");

            builder.HasKey(cs => new { cs.ClassId, cs.StudentId });

            builder.HasOne(t => t.Student).WithMany(pc => pc.ClassRoomStudents)
              .HasForeignKey(pc => pc.StudentId);
        }
    }
}
