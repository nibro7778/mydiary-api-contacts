using FluentValidation;
using MediatR;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace MyDiary.Contacts.Web.Feature.Contacts.Get
{
    public class GetContactRequest : IRequest<GetContactResponse>
    {
        public int ContactId { get; set; }
    }

    public class GetContactResponse
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int CountryCode { get; set; }
        public int MobileNo { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public string Country { get; set; }
        public string FaceBookProfileLink { get; set; }
        public string LinkedInProfileLink { get; set; }
    }

    public class GetContactValidator : AbstractValidator<GetContactRequest>
    {
        public GetContactValidator()
        {
            RuleFor(x => x.ContactId).NotEmpty();
        }
    }

    public class GetContactHandler : IRequestHandler<GetContactRequest, GetContactResponse>
    {
        public Task<GetContactResponse> Handle(GetContactRequest request, CancellationToken cancellationToken)
        {
            //TODO: write code to get contact from DB
            return null;
        }
    }
}
