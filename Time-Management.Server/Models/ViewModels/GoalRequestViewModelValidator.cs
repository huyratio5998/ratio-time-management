using FluentValidation;

namespace Time_Management.Server.Models.ViewModels
{
    public class GoalRequestViewModelValidator : AbstractValidator<GoalRequestViewModel>
    {
        public GoalRequestViewModelValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.");
            RuleFor(x => x.PageNumber).GreaterThan(0).WithMessage("Page number must be greater than 0.");
            RuleFor(x => x.PageSize).GreaterThan(0).WithMessage("Page size must be greater than 0.");
            // Add more rules as needed
        }
    }
}
