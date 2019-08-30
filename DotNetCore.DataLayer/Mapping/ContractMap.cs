using DotNetCore.Model;
using DotNetCore.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetCore.DataLayer.Mapping
{
    public class ContractMap : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contracts")
           .HasDiscriminator<int>("ContractType")
           .HasValue<MobileContract>((int)ContractType.Mobile)
           .HasValue<TvContract>((int)ContractType.Tv)
           .HasValue<BroadBandContract>((int)ContractType.BroadBand);
        }
    }
}
