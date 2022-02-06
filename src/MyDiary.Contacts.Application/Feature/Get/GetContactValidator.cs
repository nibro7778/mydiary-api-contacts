using FluentValidation;

namespace MyDiary.Contacts.Application.Feature.Get
{
    public class GetContactValidator : AbstractValidator<GetContactRequest>
    {
        public GetContactValidator()
        {
            RuleFor(x => x.ContactId).NotEmpty();
        }
    }
}
