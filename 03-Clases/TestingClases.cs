partial class Program
{
    static void TestingClass()
    {
        Vehicle honda = new Vehicle();
        honda.Brand = "Honda";
        honda.Model = "Civic";
        honda.Year = 2016;
        honda.ShowInfo();

        Vehicle toyota  = new Vehicle{Brand="Toyota", Model="Corolla", Year=2018};
        toyota.ShowInfo();

        Vehicle renault = new Vehicle("Renault", "Duster", 2024);
        renault.ShowInfo();
    }
}

class Vehicle
{
    // Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle(){}

    // Metodos
    public void ShowInfo()
    {
        WriteLine($"Este vehiculo es un {Brand} {Model} del año {Year}");
    }


}