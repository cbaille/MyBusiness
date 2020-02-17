using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyBusiness.Authorization.Roles;
using MyBusiness.Authorization.Users;
using MyBusiness.MultiTenancy;

namespace MyBusiness.EntityFrameworkCore
{
    public class MyBusinessDbContext : AbpZeroDbContext<Tenant, Role, User, MyBusinessDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyBusinessDbContext(DbContextOptions<MyBusinessDbContext> options)
            : base(options)
        {
        }
    }
}
