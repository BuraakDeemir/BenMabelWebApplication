using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class OrderPriceConfiguration : IEntityTypeConfiguration<OrderPrice>
    {
        public void Configure(EntityTypeBuilder<OrderPrice> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.TotalPrice).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(x => x.Order).WithOne(x => x.OrderPrice).HasForeignKey<OrderPrice>(x => x.OrderId);
        }
    }
}
