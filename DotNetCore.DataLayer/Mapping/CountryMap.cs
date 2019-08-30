using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.Property(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Code).IsRequired().HasMaxLength(20).IsUnicode(false);

            builder.Property(e => e.IsActive).HasDefaultValue(true);
            // builder.Property(a => a.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            builder.Property(a => a.TimeStamp).IsRowVersion();

        }
    }
}
