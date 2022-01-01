// See https://aka.ms/new-console-template for more information
using Domain;
using Domain.Entities;


DateSeeding dateSeeding = new DateSeeding();

List<Product> products = dateSeeding.GetProducts();

Console.WriteLine($"Number of object {Product.NumberOfProduct}");