using Microsoft.EntityFrameworkCore;
using MoodTrackerAPI.Models;

namespace SignToSeminarBackEnd.Context
{
    public class STSDBContext : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public STSDBContext(DbContextOptions<STSDBContext> options) : base(options)
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