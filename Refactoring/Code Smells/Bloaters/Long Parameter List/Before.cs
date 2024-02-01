public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Manufacturer { get; set; }

    public Product(string name, string description, decimal price, string category, DateTime manufactureDate, string manufacturer)
    {
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        ManufactureDate = manufactureDate;
        Manufacturer = manufacturer;
    }
}
