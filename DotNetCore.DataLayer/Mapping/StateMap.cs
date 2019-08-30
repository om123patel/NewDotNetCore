using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State");
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Code).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.CountryId).IsRequired();

            builder.HasOne(d => d.country)
           .WithMany(p => p.States)
           .HasForeignKey(d => d.CountryId)
           .OnDelete(DeleteBehavior.ClientSetNull)
           .HasConstraintName("FK_Country_State_CountryId");

            builder.Property(e => e.IsActive).HasDefaultValue(true);
            //builder.Property(a => a.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

        }
    }
}
