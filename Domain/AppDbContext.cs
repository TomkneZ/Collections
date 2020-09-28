using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Collections.Domain.Entities;

namespace Collections.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Item> Items { get; set; }     

        public DbSet<Collection> Collections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "33425d95-7608-3zc7-a77z-e160zd8c5dza",
                Name = "user",
                NormalizedName = "USER"
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2a52361d-3e55-38ez-z19e-d6574a8454c7",
                UserName = "Ksu2001",
                NormalizedUserName = "KSU2001",
                Email = "ksusha@email.com",
                NormalizedEmail = "KSUSHA@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "password"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2a99991d-3e99-99ez-z19e-d6574a8454c7",
                UserName = "Toknez",
                NormalizedUserName = "TOKNEZ",
                Email = "zabenkotoi@gmail.com",
                NormalizedEmail = "ZABENKOTOI@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "123456"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2a00001d-3e00-99ez-z00e-d6574a8454c7",
                UserName = "hannarenets",
                NormalizedUserName = "HANNARENETS",
                Email = "zabenkoea@yandex.ru",
                NormalizedEmail = "ZABENKOEA@YANDEX.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "59466"),
                SecurityStamp = string.Empty
            });


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "33425d95-7608-3zc7-a77z-e160zd8c5dza",
                UserId = "2a52361d-3e55-38ez-z19e-d6574a8454c7"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "33425d95-7608-3zc7-a77z-e160zd8c5dza",
                UserId = "2a99991d-3e99-99ez-z19e-d6574a8454c7"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "33425d95-7608-3zc7-a77z-e160zd8c5dza",
                UserId = "2a00001d-3e00-99ez-z00e-d6574a8454c7"
            });

            // какая-то дичь 
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord = "PageIndex",
                Title = "Main"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PageServices",
                Title = "Our services"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                CodeWord = "PageContacts",
                Title = "Contact us"
            });
        }
    }
}
