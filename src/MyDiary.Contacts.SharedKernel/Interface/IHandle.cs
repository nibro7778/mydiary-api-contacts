using System.Threading.Tasks;

namespace MyDiary.Contacts.SharedKernel.Interface
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
