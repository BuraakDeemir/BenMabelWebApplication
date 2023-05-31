using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class PersonUserConfiguration : IEntityTypeConfiguration<PersonUser>
    {
        public void Configure(EntityTypeBuilder<PersonUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.Person).WithOne(x => x.PersonUser).HasForeignKey<PersonUser>(x => x.PersonId);
        }
    }
}
