namespace AwesomeShopPatterns.API.Application.Models;

public record OrderInputModel
(
    CustomerInputModel Customer,
    List<OrderItemInputModel> Items,
    DeliveryAddressInputModel DeliveryAddress,
    PaymentAddressInputModel PaymentAddress,
    PaymentInfoInputModel PaymentInfo,
    bool? IsInternational
);
