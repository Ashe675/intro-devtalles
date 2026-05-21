partial class Program
{
    static void InventaryManager()
    {
        string[] products = ["Monitor", "Mouse", "Keyboard", "Headphones"];
        int[] stock = [10, 25, 15, 5];
        double[] prices = [199.99, 29.99, 49.99, 89.99];
        bool flag = true;
        do
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Inventario de productos:");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]} - Stock: {stock[i]}, Precio: ${prices[i]}");
            }

            Console.WriteLine("\nIngrese el número del producto para actualizar su stock (0 para salir):");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int productNumber) || productNumber < 0 || productNumber > products.Length)
            {
                Console.WriteLine("Número de producto inválido. Intente nuevamente.");
                continue;
            }
            if (productNumber == 0)
            {
                flag = false;
                Console.WriteLine("Saliendo del inventario...");
                break;
            }

            Console.WriteLine($"Ingrese la cantidad que desea comprar del producto {products[productNumber - 1]}:");
            string? quantityInput = Console.ReadLine();

            if (!int.TryParse(quantityInput, out int quantity) || quantity < 0)
            {
                Console.WriteLine("Cantidad inválida. Intente nuevamente.");
                continue;
            }
            if (quantity > stock[productNumber - 1])
            {
                Console.WriteLine("Stock insuficiente. Intente nuevamente.");
                continue;
            }
            stock[productNumber - 1] -= quantity;
            double totalPrice = quantity * prices[productNumber - 1];
            Console.WriteLine($"Compra realizada: {quantity} x {products[productNumber - 1]} - Total: ${totalPrice:F2}");

            Console.WriteLine("¿Desea realizar otra compra? (s/n)");
            string? continueInput = Console.ReadLine();
            if (continueInput == null || continueInput.ToLower() != "s")
            {
                flag = false;
                Console.WriteLine("Saliendo del inventario...");
            }
        } while (flag == true);
    }

}