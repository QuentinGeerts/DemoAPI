namespace Bll.Entities;

public class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public Product(int id, string name, decimal price) : this(name, price)
    {
        Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}