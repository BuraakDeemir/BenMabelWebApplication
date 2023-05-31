using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class BasketDetailConfiguration : IEntityTypeConfiguration<BasketDetail>
    {
        public void Configure(EntityTypeBuilder<BasketDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Piece).IsRequired();
            builder.Property(x => x.KDV).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.TotalPrice).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(x => x.Basket).WithMany(x => x.BasketDetail).HasForeignKey(x => x.BasketId);
            builder.HasOne(x => x.Product).WithMany(x => x.BasketDetail).HasForeignKey(x => x.ProductId);
        }
    }
}
