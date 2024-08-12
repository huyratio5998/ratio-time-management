using FluentValidation;
using FluentValidation.Results;

namespace Time_Management.Server.Models.ViewModels
{
    public interface IValidationService
    {
        ValidationResult Validate<T>(T instance);
    }
    public class ValidationService : IValidationService
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ValidationResult Validate<T>(T instance)
        {
            var validator = _serviceProvider.GetService<IValidator<T>>();
            if (validator == null)
            {
                throw new InvalidOperationException($"No validator found for type {typeof(T).Name}");
            }

            return validator.Validate(instance);
        }
    }
}
