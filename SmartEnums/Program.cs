// See https://aka.ms/new-console-template for more information
using SmartEnums;

Console.WriteLine("Hello, World!");

var creditCard = CreditCard.FromValue(1);
Console.WriteLine($"Credit card: {creditCard} with discount of {creditCard?.Discount}");

var creditCardName = CreditCard.FromName(nameof(CreditCard.Platinum));
Console.WriteLine($"Credit card: {creditCardName} with discount of {creditCardName?.Discount}");