using Microsoft.EntityFrameworkCore;
using MyDiary.Contacts.Core.Entities;

namespace MyDiary.Contacts.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>();
        }
    }    
}
