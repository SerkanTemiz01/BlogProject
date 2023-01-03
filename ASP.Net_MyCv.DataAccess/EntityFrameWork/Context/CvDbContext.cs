using ASP.Net_MyCv.Entities.Concrete;
using CurriculumVitae.DataAccess.EntityFramework.Mapping;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.DataAccess.EntityFramework.Context
{
    public class CvDbContext : DbContext
    {
        public CvDbContext(DbContextOptions<CvDbContext> options) : base(options)
        {

        }
        public CvDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminMapping()).ApplyConfiguration(new AboutMapping()).ApplyConfiguration(new ContactMapping()).ApplyConfiguration(new ProjectMapping()).ApplyConfiguration(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }

        public class CvDbContextFactory : IDesignTimeDbContextFactory<CvDbContext>
        {
            public CvDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<CvDbContext>();
                optionsBuilder.UseSqlServer("Server=LAPTOP-H9PBUUIN\\MSSQLSERVER2019;Database=CvDb;Trusted_Connection=true;TrustServerCertificate=True;");


                return new CvDbContext(optionsBuilder.Options);
            }
        }
    }


}

