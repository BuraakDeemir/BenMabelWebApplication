using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class PersonEmailConfiguration : IEntityTypeConfiguration<PersonEmail>
    {
        public void Configure(EntityTypeBuilder<PersonEmail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonEmail).HasForeignKey(x => x.PersonId);
        }
    }
}
