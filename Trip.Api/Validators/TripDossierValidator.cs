using FluentValidation;
using Trip.API.ViewModels;

namespace Trip.API.Validators.Dossier
{
    public class TripDossierValidator : AbstractValidator<TripDossierViewModel>
    {
        public TripDossierValidator()
        {
            RuleFor(m => m.DossierNumber).NotEmpty().WithMessage("Dossier Number could not be empty");
            RuleFor(m => m.DossierNumber).MaximumLength(30).WithMessage("Dossier number must not exceed 30 caracters");
        }
    }
}