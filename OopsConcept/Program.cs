// See https://aka.ms/new-console-template for more information
using OopsConcept;

Console.WriteLine("Hello, World!");

ChromeBook chromeBook = new()
{
    Name = "Chrome Book"
};
Console.WriteLine($"Name :  {chromeBook.Name}");


GooglePixelMobile googlePixelMobile = new()
{
    Name = "Google Pixel",
    Price = 30000,
    CompanyCost = 15000,
    DevelopmentCost = 7000,
    LightWeight = true
};

Console.WriteLine($"Name : {googlePixelMobile.Name}");
googlePixelMobile.PriceBenchmark();

GoogleBookTablet googleBookTablet = new()
{
    Name = "Google Book",
    Price = 45000,
    CompanyCost = 17000,
    DevelopmentCost = 9000,
    ResearchCost = 5000
};
Console.WriteLine($"Name : {googleBookTablet.Name}");
googleBookTablet.PriceBenchmark();