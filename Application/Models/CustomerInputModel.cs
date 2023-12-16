namespace AwesomeShopPatterns.API.Application.Models;

public record CustomerInputModel
(
    Guid Id,
    string FullName,
    string Email,
    string Document
);
