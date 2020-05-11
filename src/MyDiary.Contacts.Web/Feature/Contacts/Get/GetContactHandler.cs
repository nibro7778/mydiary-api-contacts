using MediatR;
using MyDiary.Contacts.Core.Entities;
using MyDiary.Contacts.SharedKernel.Interface;
using System.Threading;
using System.Threading.Tasks;

namespace MyDiary.Contacts.Web.Feature.Contacts.Get
{
    public class GetContactHandler : IRequestHandler<GetContactRequest, GetContactResponse>
    {
        private readonly IRepository _repository;

        public GetContactHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetContactResponse> Handle(GetContactRequest request, CancellationToken cancellationToken)
        {
            var contact = await _repository.GetByIdAsync<Contact>(request.ContactId);

            return new GetContactResponse()
            {
                FirstName = contact.FirstName,
                MiddleName = contact.MiddleName,
                LastName = contact.LastName,
                CountryCode = contact.CountryCode,
                MobileNo = contact.MobileNo,
                EmailAddress = contact.EmailAddress,
                DOB = contact.DOB,
                Address1 = contact.Address1,
                Address2 = contact.Address2,
                City = contact.City,
                State = contact.State,
                PinCode = contact.PinCode,
                Country = contact.Country,
                FaceBookProfileLink = contact.FaceBookProfileLink,
                LinkedInProfileLink = contact.LinkedInProfileLink
            };
        }        
    }
}
