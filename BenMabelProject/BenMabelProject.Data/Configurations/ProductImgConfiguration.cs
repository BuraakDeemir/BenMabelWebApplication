using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class ProductImgConfiguration : IEntityTypeConfiguration<ProductImg>
    {
        public void Configure(EntityTypeBuilder<ProductImg> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(x => x.Product).WithOne(x => x.ProductImg).HasForeignKey<ProductImg>(x => x.ProductId);
        }
    }
}
