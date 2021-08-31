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
            optionsBuilder.UseNpgsql("");
        }
        public DbSet<Word> Words { get; set; }
        public DbSet<Try> Tries { get; set; }
        public DbSet<User> Users { get; set; }

    }
}