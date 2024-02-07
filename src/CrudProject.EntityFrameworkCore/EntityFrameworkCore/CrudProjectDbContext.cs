using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CrudProject.Authorization.Roles;
using CrudProject.Authorization.Users;
using CrudProject.MultiTenancy;
using CrudProject.Models;

namespace CrudProject.EntityFrameworkCore
{
    public class CrudProjectDbContext : AbpZeroDbContext<Tenant, Role, User, CrudProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CrudProjectDbContext(DbContextOptions<CrudProjectDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
