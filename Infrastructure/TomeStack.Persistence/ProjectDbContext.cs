using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TomeStack.Domain.Entities;
using TomeStack.Domain.Values;

namespace TomeStack.Persistence
{
    public class ProjectDbContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=TomeStack;Username=postgres;Password=112158");
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
                .IsRequired()
                .HasDefaultValue(true);
            });
        }
    }
}
