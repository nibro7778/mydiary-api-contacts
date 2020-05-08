using FluentValidation;

namespace MyDiary.Contacts.Web.Feature.Contacts.Create
{
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
}
