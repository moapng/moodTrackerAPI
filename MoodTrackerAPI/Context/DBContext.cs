using Microsoft.EntityFrameworkCore;
using MoodTrackerAPI.Models;

namespace MoodTrackerAPI.Context
{
    public class DBContext : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<MoodDataModel> MoodData { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MOAAAAAAAAA\SQLEXPRESS01;Database=MoodTrackerDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}