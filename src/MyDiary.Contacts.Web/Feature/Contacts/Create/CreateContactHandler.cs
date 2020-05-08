using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MyDiary.Contacts.Web.Feature.Contacts.Create
{
    public class CreateContactHandler : IRequestHandler<CreateContactRequest, CreateContactResponse>
    {
        public Task<CreateContactResponse> Handle(CreateContactRequest request, CancellationToken cancellationToken)
        {
            //TODO: Add Code to add new customer to DB
            return null;
        }
    }

}
