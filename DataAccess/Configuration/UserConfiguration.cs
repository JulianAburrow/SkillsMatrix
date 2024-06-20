using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("User");
            builder.HasKey(nameof(UserModel.UserId));
            builder.Property(e => e.FirstName)
                .IsUnicode(false);
            builder.Property(e => e.LastName)
                .IsUnicode(false);
            builder.HasMany(e => e.UserSkill)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
