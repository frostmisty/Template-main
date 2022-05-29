using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entity;

namespace Infrastructure.Context
{
    public class MainTemplateContext : DbContext
    {
        public MainTemplateContext(DbContextOptions<MainTemplateContext> options) : base(options)
        {

        }
        public DbSet<MsEnumitem> MsEnumItems { get; set; }
        public DbSet<MsMenu> MsMenus { get; set; }
        public DbSet<MsModule> MsModules { get; set; }
        public DbSet<MsPage> MsPages { get; set; }
        public DbSet<MsUser> MsUsers { get; set; }
        public DbSet<MsUserRole> MsUserRoles { get; set; }
        public DbSet<MsUserRoleAccess> MsUserRoleAccesss { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<MsUser>().HasKey(x => new { x.UserId, x.ModuleId });
            builder.Entity<MsUser>().HasKey(x => new { x.UserId, x.ModuleId });
            builder.Entity<MsEnumitem>().Property(x => x.ActiveFlag).HasDefaultValueSql("Y");
            builder.Entity<MsEnumitem>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
        }
    }
}
