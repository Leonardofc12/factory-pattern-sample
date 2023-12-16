namespace AwesomeShopPatterns.API.Application.Models;

public record DeliveryAddressInputModel
(
    string Street,
    string Number,
    string City,
    string State,
    string ZipCode
);
