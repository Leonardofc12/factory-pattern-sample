using AwesomeShopPatterns.API.Infrastructure.Payments;

namespace AwesomeShopPatterns.API.Helpers;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<CreditCardService>()
                .AddScoped<IPaymentService, CreditCardService>(s => s.GetRequiredService<CreditCardService>());

        services.AddScoped<PaymentSlipService>()
                .AddScoped<IPaymentService, PaymentSlipService>(s => s.GetRequiredService<PaymentSlipService>());

        services.AddScoped<IPaymentServiceFactory, PaymentServiceFactory>();

        return services;
    }
}
