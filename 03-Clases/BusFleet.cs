/*
=============
🏆 Ejercicio 
=============
*/
// 1. Crear una clase "Bus" con las siguientes propiedades:
//    - Brand (public)
//    - Model (public)
//    - Year (public)
//    - Price (public)
//    - TotalKilometers (public)
//
// 2. Implementar un constructor para inicializar los valores.
// 3. Agregar un método "Drive(int kilometers)" que aumente el kilometraje.
// 5. Agregar un método "ShowPrice()" que nos devuelva el precio del bus.
// 6. Crear una clase "Fleet" que administre una lista de buses.
//    - Método para agregar buses a la flota.
//    - Método mostrar el listado de buses.
//
// 7. Instanciar al menos tres objetos de la clase Bus, agregarlos a la Fleet y simular la conducción de 5000.
// 8. Mostrar los detalles de la flota antes y después de la conducción.
partial class Program
{
    static void BusFleet()
    {
        Bus bus1 = new Bus("Toyota", "Corolla", 2018, 25000, 10000);
        Bus bus2 = new Bus("Honda", "Civic", 2020, 28000, 12000);
        Bus bus3 = new Bus("Ford", "Focus", 2019, 26000, 11000);

        Fleet fleet = new Fleet();
        fleet.AddBus(bus1);
        fleet.AddBus(bus2);
        fleet.AddBus(bus3);

        fleet.ShowBuses();

        bus1.Drive(5000);
        bus2.Drive(6000);
        bus3.Drive(4000);

        fleet.ShowBuses();
    }

    class Bus
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int TotalKilometers { get; set; }

        public Bus(string brand, string model, int year, double price, int totalKilometers)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            TotalKilometers = totalKilometers;
        }

        public void Drive(int kilometers)
        {
            TotalKilometers += kilometers;
        }

        public double ShowPrice()
        {
            return Price;
        }
    }

    class Fleet
    {
        private List<Bus> buses = new();

        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void ShowBuses()
        {
            WriteLine("Buses en la flota:");
            WriteLine("===================");
            foreach (var bus in buses)
            {
                WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Año: {bus.Year}, Kilometraje: {bus.TotalKilometers} --- Precio: {bus.ShowPrice()}");
            }
        }
    }

}

