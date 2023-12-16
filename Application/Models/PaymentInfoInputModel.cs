using AwesomeShopPatterns.API.Core.Enums;

namespace AwesomeShopPatterns.API.Application.Models;

public record PaymentInfoInputModel
(
    PaymentMethod PaymentMethod,
    string CardNumber,
    string FullName,
    string ExpirationDate,
    string Cvv
);