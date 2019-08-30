using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class DesignationMap : IEntityTypeConfiguration<Designation>
    {
        public void Configure(EntityTypeBuilder<Designation> builder)
        {
            builder.ToTable("Designation");
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(d => d.Code).IsRequired().HasMaxLength(20).IsUnicode(false);

            builder.Property(e => e.IsActive).HasDefaultValue(true);
           // builder.Property(a => a.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();



        }
    }
}
