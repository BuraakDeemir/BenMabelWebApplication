using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class OrderSituationConfiguration : IEntityTypeConfiguration<OrderSituation>
    {
        public void Configure(EntityTypeBuilder<OrderSituation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Situation).IsRequired();
            builder.HasOne(x => x.Order).WithOne(x => x.OrderSituation).HasForeignKey<OrderSituation>(x => x.OrderId);
        }
    }
}
