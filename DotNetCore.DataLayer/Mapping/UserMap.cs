using DotNetCore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.UserId).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Password).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.ConfirmPassword).IsRequired().HasMaxLength(50).IsUnicode(false);
        }
    }
}
