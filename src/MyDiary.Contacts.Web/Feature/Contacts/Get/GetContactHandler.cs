using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MyDiary.Contacts.Web.Feature.Contacts.Get
{
    public class GetContactHandler : IRequestHandler<GetContactRequest, GetContactResponse>
    {
        public Task<GetContactResponse> Handle(GetContactRequest request, CancellationToken cancellationToken)
        {
            //TODO: write code to get contact from DB
            return null;
        }
    }
}
