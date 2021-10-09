using System.Configuration;
using JapaneseLessons.Models;
using Microsoft.EntityFrameworkCore;

namespace JapaneseLessons.Context
{
    public class MyLessonsContext :DbContext
    {
        public MyLessonsContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // local host is not such sensitive data)
            optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
            
        }
        public DbSet<Word> Words { get; set; }
        public DbSet<Try> Tries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DefaultUser> DefaultUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DefaultUser>().HasKey(x=>x.UserKey);
            

        }
    }
}