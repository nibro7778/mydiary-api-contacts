using Microsoft.EntityFrameworkCore;
using MyDiary.Contacts.Domain.Entities;

namespace MyDiary.Contacts.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>();
        }
        
    }    
}
