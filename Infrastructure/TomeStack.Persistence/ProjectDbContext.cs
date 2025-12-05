using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TomeStack.Domain.Entities;

namespace TomeStack.Persistence
{
    public class ProjectDbContext : IdentityDbContext<User>
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            //User settings
            builder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

                entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(30);

                entity.Property(e => e.ProfileImageUrl)
                .IsRequired();

                entity.Property(e => e.UserIsActive)
                .IsRequired();
            });
        }
    }
}
