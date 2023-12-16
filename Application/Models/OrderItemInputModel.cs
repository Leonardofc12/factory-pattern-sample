namespace AwesomeShopPatterns.API.Application.Models;

public record OrderItemInputModel
(
    Guid ProductId,
    int Quantity,
    decimal Price
);
