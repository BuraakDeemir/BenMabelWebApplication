using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class OrderConfiguraiton : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Stuation).IsRequired();
            builder.HasOne(x => x.Person).WithMany(x => x.Order).HasForeignKey(x => x.PersonId);
        }
    }
}
