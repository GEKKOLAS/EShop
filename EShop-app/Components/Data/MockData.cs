using static EShop_app.Components.Pages.ProductCatalog;

  public static class ProductData
{
    public static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Name = "Ultra HD Smart TV",
            Description = "55-inch 4K Smart LED TV with HDR and built-in streaming",
            Price = 699.99m,
            Category = "Electronics",
            StockQuantity = 25,
            IsAvailable = true,
            ImageUrl = "/images/tv.jpg",
            DateAdded = DateTime.Now.AddMonths(-2)
        },
        new Product
        {
            Id = 2,
            Name = "Professional Blender",
            Description = "High-performance 1200W blender with multiple speed settings",
            Price = 199.99m,
            Category = "Kitchen Appliances",
            StockQuantity = 42,
            IsAvailable = true,
            ImageUrl = "/images/blender.jpg",
            DateAdded = DateTime.Now.AddMonths(-1)
        },
        new Product
        {
            Id = 3,
            Name = "Wireless Gaming Mouse",
            Description = "Ergonomic gaming mouse with RGB lighting and programmable buttons",
            Price = 79.99m,
            Category = "Gaming",
            StockQuantity = 115,
            IsAvailable = true,
            ImageUrl = "/images/mouse.jpg",
            DateAdded = DateTime.Now.AddDays(-15)
        },
        new Product
        {
            Id = 4,
            Name = "Coffee Maker Deluxe",
            Description = "12-cup programmable coffee maker with auto-shutoff",
            Price = 129.99m,
            Category = "Kitchen Appliances",
            StockQuantity = 30,
            IsAvailable = true,
            ImageUrl = "/images/coffee.jpg",
            DateAdded = DateTime.Now.AddDays(-45)
        },
        new Product
        {
            Id = 5,
            Name = "Fitness Smartwatch",
            Description = "Water-resistant smartwatch with heart rate monitor and GPS",
            Price = 249.99m,
            Category = "Wearables",
            StockQuantity = 78,
            IsAvailable = true,
            ImageUrl = "/images/watch.jpg",
            DateAdded = DateTime.Now.AddDays(-30)
        },
        new Product
        {
            Id = 6,
            Name = "Wireless Earbuds",
            Description = "True wireless earbuds with noise cancellation and long battery life",
            Price = 159.99m,
            Category = "Electronics",
            StockQuantity = 200,
            IsAvailable = true,
            ImageUrl = "/images/earbuds.jpg",
            DateAdded = DateTime.Now.AddDays(-60)
        },
        new Product
        {
            Id = 7,
            Name = "Gaming Laptop",
            Description = "15.6-inch gaming laptop with RTX 3060 and 16GB RAM",
            Price = 1299.99m,
            Category = "Electronics",
            StockQuantity = 12,
            IsAvailable = true,
            ImageUrl = "/images/laptop.jpg",
            DateAdded = DateTime.Now.AddDays(-20)
        },
        new Product
        {
            Id = 8,
            Name = "Air Purifier",
            Description = "HEPA air purifier with PM2.5 filter and quiet operation",
            Price = 199.99m,
            Category = "Home Appliances",
            StockQuantity = 45,
            IsAvailable = true,
            ImageUrl = "/images/purifier.jpg",
            DateAdded = DateTime.Now.AddDays(-25)
        },
        new Product
        {
            Id = 9,
            Name = "Mechanical Keyboard",
            Description = "RGB mechanical keyboard with brown switches",
            Price = 129.99m,
            Category = "Gaming",
            StockQuantity = 88,
            IsAvailable = true,
            ImageUrl = "/images/keyboard.jpg",
            DateAdded = DateTime.Now.AddDays(-40)
        },
        new Product
        {
            Id = 10,
            Name = "Robot Vacuum",
            Description = "Smart robot vacuum with mapping and app control",
            Price = 399.99m,
            Category = "Home Appliances",
            StockQuantity = 0,
            IsAvailable = false,
            ImageUrl = "/images/vacuum.jpg",
            DateAdded = DateTime.Now.AddDays(-50)
        },
        new Product
        {
            Id = 11,
            Name = "Wireless Speaker",
            Description = "Portable Bluetooth speaker with 20-hour battery life",
            Price = 89.99m,
            Category = "Electronics",
            StockQuantity = 65,
            IsAvailable = true,
            ImageUrl = "/images/speaker.jpg",
            DateAdded = DateTime.Now.AddDays(-35)
        },
        new Product
        {
            Id = 12,
            Name = "Electric Toothbrush",
            Description = "Smart electric toothbrush with pressure sensor",
            Price = 79.99m,
            Category = "Personal Care",
            StockQuantity = 150,
            IsAvailable = true,
            ImageUrl = "/images/toothbrush.jpg",
            DateAdded = DateTime.Now.AddDays(-55)
        },
        new Product
        {
            Id = 13,
            Name = "Stand Mixer",
            Description = "Professional 5-quart stand mixer with multiple attachments",
            Price = 349.99m,
            Category = "Kitchen Appliances",
            StockQuantity = 28,
            IsAvailable = true,
            ImageUrl = "/images/mixer.jpg",
            DateAdded = DateTime.Now.AddDays(-65)
        },
        new Product
        {
            Id = 14,
            Name = "Gaming Console",
            Description = "Next-gen gaming console with 1TB storage",
            Price = 499.99m,
            Category = "Gaming",
            StockQuantity = 0,
            IsAvailable = false,
            ImageUrl = "/images/console.jpg",
            DateAdded = DateTime.Now.AddDays(-70)
        },
        new Product
        {
            Id = 15,
            Name = "Smart Thermostat",
            Description = "WiFi-enabled smart thermostat with energy saving features",
            Price = 179.99m,
            Category = "Home Appliances",
            StockQuantity = 92,
            IsAvailable = true,
            ImageUrl = "/images/thermostat.jpg",
            DateAdded = DateTime.Now.AddDays(-45)
        }
    };
}