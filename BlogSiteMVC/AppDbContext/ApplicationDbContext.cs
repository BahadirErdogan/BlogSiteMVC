using BlogSiteMVC.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteMVC.AppDbContext
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {

        }

        //AppUser için DbSet tanımlanmadı.(Identity)

        public DbSet<Article> Articles { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder); //The entity type 'IdentityUserLogin<string>' requires a primary key to be defined.
            modelbuilder.Entity<Article>().Property(a => a.Title).HasMaxLength(140).IsRequired();
            modelbuilder.Entity<Topic>().Property(a => a.Name).HasMaxLength(50).IsRequired();

        }
    }
}
