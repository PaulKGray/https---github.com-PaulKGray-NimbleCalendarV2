using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NimbleCalandar.Authorization.Roles;
using NimbleCalandar.Authorization.Users;
using NimbleCalandar.MultiTenancy;

namespace NimbleCalandar.EntityFrameworkCore
{
    public class NimbleCalandarDbContext : AbpZeroDbContext<Tenant, Role, User, NimbleCalandarDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NimbleCalandarDbContext(DbContextOptions<NimbleCalandarDbContext> options)
            : base(options)
        {
        }
    }
}
