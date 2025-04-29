// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
/*
 * Bir nesne ......GELİŞİME........... açık ........DEĞİŞİME...... kapalı olmalıdır.
 * 
 */

Customer customer = new Customer() { Name="Türkay", Card= new Premium()};
OrderManagement orderManagement = new OrderManagement() { Customer = customer};
var discountedPrice = orderManagement.GetTotalPrice(1000);
Console.WriteLine(discountedPrice.ToString("C2"));
