using DataAccess.Configuration;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class STMGroupSkillsMatrixContext : DbContext
    {
        public STMGroupSkillsMatrixContext(DbContextOptions<STMGroupSkillsMatrixContext> options)
            : base(options)
        { }

        public DbSet<SkillModel> SkillModel { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<UserSkillModel> UserSkill { get; set; }
        public DbSet<UserStatusModel> UserStatus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserSkillConfiguration());
            modelBuilder.ApplyConfiguration(new UserStatusConfiguration());
        }
    }
}
