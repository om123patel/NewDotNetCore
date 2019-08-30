using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Code).IsRequired().HasMaxLength(20).IsUnicode(false);

            builder.Property(e => e.IsActive).HasDefaultValue(true);
            //builder.Property(a => a.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

        }
    }
}
