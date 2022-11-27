using Discovercars.Domain.Requests;
using FluentValidation;

namespace Discovercars.Api.Validators
{
    public class ReservationRequestValidators : AbstractValidator<ReservationRequest>
    {
        public ReservationRequestValidators()
        {
            RuleFor(p => p.OfferUid).NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!");
            RuleFor(p => p.Customer.Name).NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!");
            RuleFor(p => p.Customer.Surname).NotEmpty().WithMessage("{PropertyName} should be not empty. NEVER!");
        }
    }
}
