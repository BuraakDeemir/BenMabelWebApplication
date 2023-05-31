using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class PersonAdressConfiguration : IEntityTypeConfiguration<PersonAdress>
    {
        public void Configure(EntityTypeBuilder<PersonAdress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PersonId).IsRequired();
            builder.Property(x => x.Ctiy).IsRequired().HasMaxLength(50);
            builder.Property(x => x.District).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Neighbourhood).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Street).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Detail).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonAdress).HasForeignKey(x => x.PersonId);
        }
    }
}
