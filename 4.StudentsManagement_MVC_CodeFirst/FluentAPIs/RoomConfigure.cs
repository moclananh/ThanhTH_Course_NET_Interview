using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Reflection.Emit;
using _4.StudentsManagement_MVC_CodeFirst.DataAccess.Entities;

namespace _4.StudentsManagement_MVC_CodeFirst.FluentAPIs
{
    public class RoomConfigure : IEntityTypeConfiguration<ClassRoom>
    {
        public void Configure(EntityTypeBuilder<ClassRoom> builder)
        {
            builder.ToTable("ClassRoom");
            builder.HasKey(x => x.ClassId);
         
        }
    }

}
