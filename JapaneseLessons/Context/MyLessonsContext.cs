using JapaneseLessons.Models;
using Microsoft.EntityFrameworkCore;
using Try = JapaneseLessons.Models.Try;
using User = JapaneseLessons.Models.User;
using Word = JapaneseLessons.Models.Word;

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
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=japanese;Username=postgres;Password=password");
            
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