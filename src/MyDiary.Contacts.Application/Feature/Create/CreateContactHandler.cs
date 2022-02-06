using MediatR;
using MyDiary.Contacts.Domain.Entities;

namespace MyDiary.Contacts.Application.Feature.Create
{
    public class CreateContactHandler : IRequestHandler<CreateContactRequest, CreateContactResponse>
    {
        private readonly IRepository _repository;

        public CreateContactHandler(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<CreateContactResponse> Handle(CreateContactRequest request, CancellationToken cancellationToken)
        {            
            var contact = new Contact()
            {
                FirstName = request.FirstName,
                MiddleName = request.MiddleName,
                LastName = request.LastName,
                CountryCode = request.CountryCode,
                MobileNo = request.MobileNo,
                EmailAddress = request.EmailAddress,
                DOB = request.DOB,
                Address1 = request.Address1,
                Address2 = request.Address2,
                City = request.City,
                State = request.State,
                PinCode = request.PinCode,
                Country = request.Country,
                FaceBookProfileLink = request.FaceBookProfileLink,
                LinkedInProfileLink = request.LinkedInProfileLink
            };    
            contact = await _repository.AddAsync(contact);

            return new CreateContactResponse()
            {
                ContactId = contact.Id
            };           
        }
    }

}
