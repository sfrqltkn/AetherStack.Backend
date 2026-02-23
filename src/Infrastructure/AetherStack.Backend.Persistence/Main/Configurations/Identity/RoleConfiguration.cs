using AetherStack.Backend.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AetherStack.Backend.Persistence.Main.Configurations.Identity
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.Property(x => x.Name)
                .HasMaxLength(50);

            builder.Property(x => x.NormalizedName)
                .HasMaxLength(50);

            builder.HasIndex(r => r.NormalizedName)
                .IsUnique();

        }
    }
}
