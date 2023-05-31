using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("E59FF37A-4546-48D0-A6D0-B1ADB979C6B5"),
                Name = "Patron",
                NormalizedName = "PATRON",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new AppRole
            {
                Id = Guid.Parse("9AD926B2-048D-4A4E-83D3-E6A32BFAB16A"),
                Name = "Finans Uzmanı",
                NormalizedName = "FINANS UZMANI",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
             new AppRole
             {
                 Id = Guid.Parse("00B258BC-7991-4FF1-A277-2B56E27E8A97"),
                 Name = "Customer",
                 NormalizedName = "CUSTOMER",
                 ConcurrencyStamp = Guid.NewGuid().ToString(),
             },
            new AppRole
            {
                Id = Guid.Parse("8123BD2D-552C-4CDC-A7D3-8B73D44521FD"),
                Name = "Rapor Uzmanı",
                NormalizedName = "RAPOR UZMANI",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new AppRole
            {
                Id = Guid.Parse("E88C26E7-383D-457C-982A-C9C9F8BC55B2"),
                Name = "Paketleme",
                NormalizedName = "PAKETLEME",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });
        }
    }
}
