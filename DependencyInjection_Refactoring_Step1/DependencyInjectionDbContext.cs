using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection_Refactoring_Step1
{
    public class DependencyInjectionDbContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Dati\Code\DependencyInjection\Database\Database.sqlite");
        }
    }

    public class Part
    {
        [Key]
        public string Code { get; set; }
    }

}