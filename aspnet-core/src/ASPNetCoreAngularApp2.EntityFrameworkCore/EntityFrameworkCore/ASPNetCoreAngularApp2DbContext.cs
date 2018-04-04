using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ASPNetCoreAngularApp2.Authorization.Roles;
using ASPNetCoreAngularApp2.Authorization.Users;
using ASPNetCoreAngularApp2.MultiTenancy;

namespace ASPNetCoreAngularApp2.EntityFrameworkCore
{
    public class ASPNetCoreAngularApp2DbContext : AbpZeroDbContext<Tenant, Role, User, ASPNetCoreAngularApp2DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ASPNetCoreAngularApp2DbContext(DbContextOptions<ASPNetCoreAngularApp2DbContext> options)
            : base(options)
        {
        
    }
}
}
