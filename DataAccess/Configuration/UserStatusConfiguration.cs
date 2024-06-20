using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class UserStatusConfiguration : IEntityTypeConfiguration<UserStatusModel>
    {
        public void Configure(EntityTypeBuilder<UserStatusModel> builder)
        {
            builder.ToTable("UserStatus");
            builder.HasKey(nameof(UserStatusModel.StatusId));
            builder.Property(e => e.StatusName)
                .IsUnicode(false);
            builder.HasMany(e => e.User)
                .WithOne(e => e.UserStatus)
                .HasForeignKey(e => e.StatusId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
