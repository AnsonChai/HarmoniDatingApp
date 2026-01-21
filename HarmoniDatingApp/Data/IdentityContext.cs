using HarmoniDatingApp.Configurations.Entities;
using HarmoniDatingApp.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HarmoniDatingApp.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<HarmoniDatingAppUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }

    }
}
