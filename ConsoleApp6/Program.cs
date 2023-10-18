using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

class Product
{
    public double Weight { get; set; }
    public double Price { get; set; }
    public double Volume { get; set; }
    public string Name { get; set; }
    public bool Fragile { get; set; }

    public Product(double weight, double price, double volume, string name, bool fragile)
    {
        Weight = weight;
        Price = price;
        Volume = volume;
        Name = name;
        Fragile = fragile;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product(1.55, 185.70, 1.5, "Coca-Cola", false));
        products.Add(new Product(0.7, 59.99, 0.5, "Дюшес", true));
        products.Add(new Product(1.55, 134.15, 1.5, "Добрый Апельсин", false));
        products.Add(new Product(3.5, 299.00, 3.0, "Томатный сок", true));
        products.Add(new Product(1.05, 174.99, 1.0, "Pepsi", false));
        products.Add(new Product(1.05, 129.00, 1.0, "Fanta", false));
        products.Add(new Product(1.55, 129.99, 1.5, "Mirinda Mixit", false));
        products.Add(new Product(0.65, 79.99, 0.5, "Яблочный сок", true));
        products.Add(new Product(1.05, 84.90, 1.0, "Добрый Кола без сахара", false));
        products.Add(new Product(1.05, 84.90, 1.0, "Добрый Маракуйя", false));

        foreach (Product product in products)
        {
            Console.WriteLine($"{product.Name}: Вес в кг={product.Weight}, Цена в руб={product.Price}, Объём в л={product.Volume}, Хрупкий или нет={product.Fragile}");
        }

        string json = JsonConvert.SerializeObject(products, Formatting.Indented);

        File.WriteAllText("products.json", json);
    }
}