using BenMabelProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BenMabelProject.Data.Configurations
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("991C240D-593D-4201-8461-56436289D1A4"),
                RoleId = Guid.Parse("E59FF37A-4546-48D0-A6D0-B1ADB979C6B5"),
            },
            new AppUserRole
            {
                UserId = Guid.Parse("1DDC3B63-D12F-4AE8-B2D1-A9E144C81D07"),
                RoleId = Guid.Parse("9AD926B2-048D-4A4E-83D3-E6A32BFAB16A"),
            });
        }
    }
}
