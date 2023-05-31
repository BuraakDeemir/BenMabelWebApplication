using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class PersonIphoneConfiguration : IEntityTypeConfiguration<PersonIphone>
    {
        public void Configure(EntityTypeBuilder<PersonIphone> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Iphone).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonIphone).HasForeignKey(x => x.PersonId);
        }
    }
}
