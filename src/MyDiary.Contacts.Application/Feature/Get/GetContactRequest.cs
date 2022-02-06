using MediatR;

namespace MyDiary.Contacts.Application.Feature.Get
{
    public class GetContactRequest : IRequest<GetContactResponse>
    {
        public int ContactId { get; set; }
    }
}
