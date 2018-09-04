using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project.Data.Entities;

namespace project.Data
{
    public class EcommerceContext: IdentityDbContext<AppUser, AppRole, int>
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options){}
    }
}