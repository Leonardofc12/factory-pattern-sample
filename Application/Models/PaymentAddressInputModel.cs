namespace AwesomeShopPatterns.API.Application.Models;

public record PaymentAddressInputModel
(
    string Street,
    string Number,
    string City,
    string State,
    string ZipCode
);