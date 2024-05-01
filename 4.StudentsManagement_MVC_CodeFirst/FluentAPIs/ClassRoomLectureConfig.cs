using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;

namespace _4.StudentsManagement_MVC_CodeFirst.FluentAPIs
{
    public class ClassRoomLectureConfig : IEntityTypeConfiguration<ClassRoomLectures>
    {
        public void Configure(EntityTypeBuilder<ClassRoomLectures> builder)
        {
            builder.ToTable("ClassRoomLectures");

            builder.HasKey(cl => new { cl.ClassId, cl.LectureId });

            builder.HasKey(cs => new { cs.ClassId, cs.LectureId });

            builder.HasOne(t => t.Lecture).WithMany(pc => pc.ClassRoomLectures)
              .HasForeignKey(pc => pc.LectureId);

        }
    }
}
