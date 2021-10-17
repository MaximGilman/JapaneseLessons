using JapaneseLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace JapaneseLibrary.Context
{
    public class MyLessonsContext : DbContext
    {
        public MyLessonsContext(DbContextOptions<MyLessonsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Word> Words { get; set; }
        public DbSet<Try> Tries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<DefaultUser> DefaultUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DefaultUser>().HasKey(x => x.UserKey);
        }
    }
}