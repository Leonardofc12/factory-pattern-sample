using AwesomeShopPatterns.API.Application.Models;

namespace AwesomeShopPatterns.API.Infrastructure.Payments;

public class PaymentSlipService : IPaymentService
{
    public object Process(OrderInputModel model)
    {
        return "The payment slip transaction was accepted.";
    }
}