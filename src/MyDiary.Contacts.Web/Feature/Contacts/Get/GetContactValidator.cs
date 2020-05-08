using FluentValidation;

namespace MyDiary.Contacts.Web.Feature.Contacts.Get
{
    public class GetContactValidator : AbstractValidator<GetContactRequest>
    {
        public GetContactValidator()
        {
            RuleFor(x => x.ContactId).NotEmpty();
        }
    }
}
