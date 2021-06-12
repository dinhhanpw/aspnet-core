using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using pwabp.Authorization.Roles;
using pwabp.Authorization.Users;
using pwabp.MultiTenancy;

namespace pwabp.EntityFrameworkCore
{
    public class pwabpDbContext : AbpZeroDbContext<Tenant, Role, User, pwabpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public pwabpDbContext(DbContextOptions<pwabpDbContext> options)
            : base(options)
        {
        }
    }
}
