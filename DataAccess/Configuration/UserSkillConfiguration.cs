using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkillModel>
    {
        public void Configure(EntityTypeBuilder<UserSkillModel> builder)
        {
            builder.ToTable("UserSkill");
            builder.HasKey(nameof(UserSkillModel.UserSkillId));
            builder.HasOne(e => e.Skill)
                .WithMany(e => e.UserSkill)
                .HasForeignKey(e => e.SkillId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.User)
                .WithMany(e => e.UserSkill)
                .HasForeignKey(e => e.UserId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
