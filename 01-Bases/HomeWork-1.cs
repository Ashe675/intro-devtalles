partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold =3;
        decimal unitPrice = 750.99m;
        double unitPriceDouble = 750.99;
        decimal totalAmount = quantitySold * unitPrice;
        double totalAmountDouble = quantitySold * unitPriceDouble;

        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        Console.WriteLine($"Total vendido: {totalAmount}");
        Console.WriteLine($"Total vendido double: {totalAmountDouble:C}");


    }
}