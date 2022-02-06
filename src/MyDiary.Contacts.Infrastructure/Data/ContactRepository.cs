using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using MyDiary.Contacts.Application;
using MyDiary.Contacts.Domain.Entities;

namespace MyDiary.Contacts.Infrastructure.Data
{
    public class ContactRepository : IRepository
    {
        private readonly AppDbContext _dbContext;

        public ContactRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Contact>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Contact> AddAsync(Contact contact)
        {
            await _dbContext.Set<Contact>().AddAsync(contact);
            await _dbContext.SaveChangesAsync();

            return contact;
        }
    }
}
