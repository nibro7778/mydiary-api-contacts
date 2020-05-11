using System.Threading.Tasks;

namespace MyDiary.Contacts.SharedKernel.Interface
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
