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
        public DbSet<MsEnumitem> MsEnumItem { get; set; }
        public DbSet<MsMenu> MsMenu { get; set; }
        public DbSet<MsModule> MsModule { get; set; }
        public DbSet<MsPage> MsPage { get; set; }
        public DbSet<MsUser> MsUser { get; set; }
        public DbSet<MsUserRole> MsUserRole { get; set; }
        public DbSet<MsPermission> MsPermission { get; set; }
        public DbSet<MsUserRoleAccess> MsUserRoleAccess { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MsUser>().HasKey(x => new { x.UserId, x.ModuleId });
            builder.Entity<MsUser>().HasKey(x => new { x.UserId, x.ModuleId });
            //MsEnumItems
            builder.Entity<MsEnumitem>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsEnumitem>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsEnumitem>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsModule
            builder.Entity<MsModule>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsModule>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsModule>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsPage
            builder.Entity<MsPage>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsPage>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsPage>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsMenu
            builder.Entity<MsMenu>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsMenu>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsMenu>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsUserRole
            builder.Entity<MsUserRole>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsUserRole>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsMenu>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsUserRoleAccess
            builder.Entity<MsUserRoleAccess>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsUserRoleAccess>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsUserRoleAccess>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsPermission
            builder.Entity<MsPermission>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsPermission>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsPermission>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");

            //MsUser
            builder.Entity<MsUser>().Property(x => x.ActiveFlag).HasDefaultValue("Y");
            builder.Entity<MsUser>().Property(x => x.TsCrt).HasDefaultValueSql("GETDATE()");
            builder.Entity<MsUser>().Property(x => x.TsMod).HasDefaultValueSql("GETDATE()");
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
        }
    }
}
