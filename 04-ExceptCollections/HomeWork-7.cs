/*
=====================================
Análisis de Ventas con LINQ y Excepciones
=====================================
*/
// 🏆 Ejercicio:
// Desarrollar un sistema para analizar las ventas de una empresa usando colecciones y LINQ.
// Tendrás una clase "Sale" con las siguientes propiedades:
//  - Product (public)
//  - Category (public)
//  - Amount (public)
//
// También una lista con 6 ventas ficticias.
// Lo que tendrás que desarrollar es:
// 1. Filtrar y mostrar las ventas con monto superior a 1000.
// 2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.
// 3. Manejar excepciones en caso de errores al procesar los datos.

partial class Program
{
    static void SalesAnalysis()
    {
        List<Sale> sales = new List<Sale> {
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        };


        try
        {
            var filteredSales = sales.Where(x => x.Amount > 1000);
            var filteredQuery = from s in sales
                                where s.Amount > 1000
                                select s;

            WriteLine("Ventas con monto superior a 1000:");
            foreach (var sale in filteredQuery)
            {
                WriteLine($"Producto: {sale.Product}, Categoría: {sale.Category}, Monto: {sale.Amount:C}");
            }

            var totalSalesByCategory = sales.GroupBy(x => x.Category).Select(group => new { Category = group.Key, TotalAmount = group.Sum(x => x.Amount) });

            var totalSalesByCategoryQuery = from s in sales group s by s.Category into catgories select new { Category = catgories.Key, TotalAmount = catgories.Sum(x => x.Amount) };

            WriteLine("Total de ventas por categoría:");
            foreach (var category in totalSalesByCategoryQuery)
            {
                WriteLine($"Categoría: {category.Category}, Total: {category.TotalAmount:C}");
            }
        }
        catch (System.Exception ex)
        {
            WriteLine("Ocurrió un error al procesar los datos.");
            WriteLine(ex.Message);
        }

    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}