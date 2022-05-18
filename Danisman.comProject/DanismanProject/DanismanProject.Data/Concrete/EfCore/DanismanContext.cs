using DanismanProject.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanismanProject.Data.Concrete.EfCore
{
    public class DanismanContext : DbContext
    {
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<SubcategoryAdvisor> SubcategoryAdvisors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= DanismanProjectDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubcategoryAdvisor>().HasKey(sa => new { sa.AdvisorId, sa.SubcategoryId });
        }
    }
}
