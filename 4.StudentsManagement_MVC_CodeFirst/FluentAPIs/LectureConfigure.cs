using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;

namespace _4.StudentsManagement_MVC_CodeFirst.FluentAPIs
{
    public class LectureConfigure : IEntityTypeConfiguration<Lecture>
    {
        public void Configure(EntityTypeBuilder<Lecture> builder)
        {
            // Set table name
            builder.ToTable("Lectures");

            // Configure primary key
            builder.HasKey(l => l.Id);

            // Configure other properties if needed
            builder.Property(l => l.Name)
                .IsRequired();

            builder.Property(l => l.DOB)
                .IsRequired();

            builder.Property(l => l.Status)
                .IsRequired();

        }
    }
}
