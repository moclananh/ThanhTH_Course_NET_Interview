using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;

namespace _4.StudentsManagement_MVC_CodeFirst.FluentAPIs
{
    public class StudentConfigure : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            // Set table name
            builder.ToTable("Students");
            // Configure primary key
            builder.HasKey(s => s.Id);

            // Configure other properties if needed
            builder.Property(s => s.Name)
                .IsRequired();

            builder.Property(s => s.DOB)
                .IsRequired();

            builder.Property(s => s.Status)
                .IsRequired();

        }
    }
}
