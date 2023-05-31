using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.detail).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.ProductId).IsRequired();
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetail).HasForeignKey<ProductDetail>(x => x.ProductId);
        }
    }
}
