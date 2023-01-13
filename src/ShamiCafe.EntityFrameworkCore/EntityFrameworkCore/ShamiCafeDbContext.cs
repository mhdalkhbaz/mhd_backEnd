using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShamiCafe.Authorization.Roles;
using ShamiCafe.Authorization.Users;
using ShamiCafe.MultiTenancy;

namespace ShamiCafe.EntityFrameworkCore
{
    public class ShamiCafeDbContext : AbpZeroDbContext<Tenant, Role, User, ShamiCafeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ShamiCafeDbContext(DbContextOptions<ShamiCafeDbContext> options)
            : base(options)
        {
        }
    }
}
