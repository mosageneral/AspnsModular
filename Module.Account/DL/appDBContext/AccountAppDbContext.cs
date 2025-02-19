﻿using Microsoft.EntityFrameworkCore;
using Module.Account.BL.Abstraction;
using Module.Account.DL.DataSeeds;
using Module.Account.DL.Entities.UserEntites;
using Module.Account.DL.Entities.UserEntities;
using Shared.Infrastructure.Persistence;

namespace Module.Account.DL.appDBContext
{
    internal class AccountAppDbContext : ModuleDbContext, IAccountAppDbContext
    {
        protected override string Schema => "Account";

        public AccountAppDbContext(DbContextOptions<AccountAppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<PermissionRoles> PermissionRoles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VerfiyCode> VerfiyCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //UserSeeds
            modelBuilder.Entity<User>().HasData(UserSeeds.AdminUser);
            modelBuilder.Entity<User>().HasData(UserSeeds.BasicUSer);
            //RoleSeeds
            modelBuilder.Entity<Role>().HasData(RoleSeeds.AdminRole);
            modelBuilder.Entity<Role>().HasData(RoleSeeds.BasicRole);
            //PermissionSeeds
            modelBuilder.Entity<Permission>().HasData(PermissionSeeds.Archive);
            modelBuilder.Entity<Permission>().HasData(PermissionSeeds.Admin);
            //UserRolesSeeds
            modelBuilder.Entity<UserRoles>().HasData(UserRolesSeeds.UserBasic_RoleBasic);
            modelBuilder.Entity<UserRoles>().HasData(UserRolesSeeds.UserAdmin_RoleBasic);
            modelBuilder.Entity<UserRoles>().HasData(UserRolesSeeds.UserAdmin_RoleAdmin);
            //permissionRolesSeeds
            modelBuilder.Entity<PermissionRoles>().HasData(RolesPermissionSeeds.RoleBasic_PermissionGetAllUser);
            modelBuilder.Entity<PermissionRoles>().HasData(RolesPermissionSeeds.RoleAdmin_PermissionGetAllUser);
            modelBuilder.Entity<PermissionRoles>().HasData(RolesPermissionSeeds.RoleAdmin_PermissionAddUser);

            base.OnModelCreating(modelBuilder);
        }
    }
}