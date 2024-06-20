using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class SkillConfiguration : IEntityTypeConfiguration<SkillModel>
    {
        public void Configure(EntityTypeBuilder<SkillModel> builder)
        {
            builder.ToTable("Skill");
            builder.HasKey(nameof(SkillModel.SkillId));
            builder.Property(e => e.SkillName)
                .IsUnicode(false);
            builder.HasMany(s => s.UserSkill)
                .WithOne(s => s.Skill)
                .HasForeignKey(e => e.SkillId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
