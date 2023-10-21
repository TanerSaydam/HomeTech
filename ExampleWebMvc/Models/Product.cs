namespace ExampleWebMvc.Models;

public sealed class Product
{
    public Product()
    {
        
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public Money Price { get; set; } // price 100 currency $ //primitive type //Taner
}

public interface IService
{
    void Save();
}

public class Service : IService
{
    public void Save()
    {
        Console.WriteLine("Saved");
    }
}


public record Money2(
    decimal Value,
       string Currency); //Value Object

public record Money
{
    public Money(decimal value, string currency)
    {
        if(currency == "$" || currency == "€" || currency == "₺"){
            Currency = currency;
        }
        else
        {
            throw new Exception("Geçersiz para tipi girdiniz!");
        }

        if(value > 0 || value < 1000000)
        {
            Value = value;
        }
        else
        {
            throw new Exception("Geçersiz para değeri girdiniz!");
        }


    }
    public decimal Value { get; init; }
    public string Currency { get; init; }
}

public record ProductDto(
    string Name,
    decimal Price);

public record ProductDto2
{
    Product Product = new()
    {
            Id = 1, 
        Name = "Domates", 
        Price = new(100, "asdasdasd") };
    public ProductDto2(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; init; }
    public decimal Price { get; init; }
}