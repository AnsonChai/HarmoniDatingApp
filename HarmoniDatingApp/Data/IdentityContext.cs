using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HarmoniDatingApp.Data;

namespace HarmoniDatingApp.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<HarmoniDatingAppUser>(options)
    {
    }
}
