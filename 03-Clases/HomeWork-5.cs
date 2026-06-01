partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();

        Product laptop = new Product("Laptop", 11999.966, 10);
        Product phone = new Product("Smartphone", 800, 20);
        Product tv = new Product("TV", 1500, 5);

        inventory.AddProduct(laptop);
        inventory.AddProduct(phone);
        inventory.AddProduct(tv);

        inventory.ShowProducts();

        laptop.Sell(1);

        inventory.ShowProducts();


    }

    class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void ShowInfo()
        {
            WriteLine($"Producto: {Name}, Precio: {Price}, Stock: {Stock}");
        }

        public bool Sell(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                WriteLine($"Se vendieron {quantity} unidades de {Name}");
                return true;
            }
            WriteLine($"No hay suficiente stock para vender {quantity} unidades de {Name}");
            return false;
        }
    }

    class Inventory
    {
        private List<Product> Products = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ShowProducts()
        {
            WriteLine("Lista de productos en el inventario:");
            foreach (Product p in Products)
            {
                p.ShowInfo();
            }
        }

    }

}