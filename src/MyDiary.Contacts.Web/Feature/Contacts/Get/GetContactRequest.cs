using MediatR;

namespace MyDiary.Contacts.Web.Feature.Contacts.Get
{
    public class GetContactRequest : IRequest<GetContactResponse>
    {
        public int ContactId { get; set; }
    }
}
