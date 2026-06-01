partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Toyota";
        car.Year = 2018;
        WriteLine(car.ShowInfo());
        // car.ShowMessage();
        // car.ShowMessage("Cambiando el modelo");
        // car.ChangeModel("Honda");
        // WriteLine(car.ShowInfo());
        // Car.GeneralInfo();

        // *  constructor 
        Car sportsCar = new("Ferrari", 2023);
        WriteLine(sportsCar.ShowInfo());

        // * SINTAXIS SIMPLIFICADA  
        Car collectionCar = new Car { Model = "Tesla", Year = 2022 };
        WriteLine(collectionCar.ShowInfo());

        // * LISTA DE OBJETOS
        List<Car> cars = new List<Car>()
        {
            new Car(){Model="Duster", Year=2022},
            new Car(){Model="StepWay", Year=2012},
            new Car(){Model="Captur", Year=2022},

        };
        cars.Add(car);

        foreach (Car c in cars)
        {
            WriteLine(c.ShowInfo());
        }
    }


    class Car
    {
        public string? Model { get; set; }
        public int Year { get; set; }
        // * CONSTRUCTOR CON PARAMS
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
        // * COSNTRUCTOR POR DEFECTO
        public Car() { }

        // * DESTRUCTOR
        ~Car()
        {
            WriteLine($"Destructor llamado. Recurso liberado");
        }


        public void ChangeModel(string newModel)
        {
            Model = newModel;
        }

        public string ShowInfo()
        {
            return $"Este auto es un {Model} del año {Year}";
        }

        public void ShowMessage() => WriteLine($"Este es un auto");

        public void ShowMessage(string message) => WriteLine(message);

        public static void GeneralInfo()
        {
            WriteLine("El auto es uno de los transportes mas utilizados");
        }

    }
}

