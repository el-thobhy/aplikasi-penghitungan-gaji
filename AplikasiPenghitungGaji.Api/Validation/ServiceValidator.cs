using FluentValidation;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Validation
{
    public static class ServiceValidator
    {
        public static IServiceCollection AddValidator(this IServiceCollection services)
        {
            services.AddScoped<IValidator<UserViewModel>, RegisterValidator>()
                .AddScoped<IValidator<LoginViewModel>, LoginValidator>();
            return services;

        }
    }
}
