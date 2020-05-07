using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using System.Threading.Tasks;

namespace MyDiary.Contacts.Web.Feature.Contacts.Create
{
    #region Request
    public class CreateContactRequest : IRequest<CreateContactResponse>
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
    #endregion

    #region Response
    public class CreateContactResponse
    {
        public string ContactId { get; set; }
    }
    #endregion

    #region Validation
    public class CreatContactValidator : AbstractValidator<CreateContactRequest>
    {
        public CreatContactValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.CountryCode).NotEmpty();
            RuleFor(x => x.MobileNo).NotEmpty();
            RuleFor(x => x.EmailAddress).NotEmpty();
            RuleFor(x => x.Country).NotEmpty();            
        }
    }
    #endregion

    #region Handler
    public class CreateContactHandler : IRequestHandler<CreateContactRequest, CreateContactResponse>
    {
        public Task<CreateContactResponse> Handle(CreateContactRequest request, CancellationToken cancellationToken)
        {
            //TODO: Add Code to add new customer to DB
            return null;
        }
    }

    #endregion
}
