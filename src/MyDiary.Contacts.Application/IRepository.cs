using MyDiary.Contacts.Domain.Entities;

namespace MyDiary.Contacts.Application
{
    public interface IRepository
    {
        Task<Contact> GetByIdAsync(int id);
        Task<Contact> AddAsync(Contact contact);

    }
}
