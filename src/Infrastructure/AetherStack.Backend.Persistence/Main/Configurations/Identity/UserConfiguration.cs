using AetherStack.Backend.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AetherStack.Backend.Persistence.Main.Configurations.Identity
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(100);

            builder.Property(u => u.UserName).IsRequired().HasMaxLength(100);
            builder.HasIndex(u => u.UserName).IsUnique();
            builder.Property(x => x.NormalizedUserName).HasMaxLength(100);

            builder.Property(u => u.Email).HasMaxLength(256);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(x => x.NormalizedEmail).HasMaxLength(256);

            builder.Property(u => u.PhoneNumber).HasMaxLength(30);
            builder.HasIndex(u => u.PhoneNumber).IsUnique();

            builder.Property(u => u.IsActive).HasDefaultValue(true);
        }
    }
}
