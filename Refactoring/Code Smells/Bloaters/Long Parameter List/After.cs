public class ProductDetails
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Manufacturer { get; set; }

    public ProductDetails(string name, string description, decimal price, string category, DateTime manufactureDate, string manufacturer)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        ManufactureDate = manufactureDate;
        Manufacturer = manufacturer;
    }
}

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Manufacturer { get; set; }

    public Product(ProductDetails details)
    {
        Name = details.Name;
        Description = details.Description;
        Price = details.Price;
        Category = details.Category;
        ManufactureDate = details.ManufactureDate;
        Manufacturer = details.Manufacturer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProductDetails details = new ProductDetails(
            name: "Laptop",
            description: "A high-performance laptop.",
            price: 1200.00M,
            category: "Electronics",
            manufactureDate: new DateTime(2022, 1, 1),
            manufacturer: "Tech Innovations Inc."
        );

        Product product = new Product(details);

        // Now the Product constructor is cleaner and easier to manage.
    }
}
