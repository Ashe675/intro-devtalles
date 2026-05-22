partial class Program
{
    static void Tuples()
    {
        (int, string, double) person = (30, "Alice", 1.75);
        WriteLine($"Edad: {person.Item1}, Nombre: {person.Item2}, Estatura: {person.Item3}");

        var car = (Make: "Toyota", Model: "Corolla", Year: 2020);
        WriteLine($"Marca: {car.Make}, Modelo: {car.Model}, Año: {car.Year}");

        (string Name, int Age) student = ("Bob", 22);
        WriteLine($"Nombre: {student.Name}, Edad: {student.Age}");

        var operations = Calculate(10, 5);
        WriteLine($"Suma: {operations.Sum}, Resta: {operations.Substract}");

        (int sum, int substract) = Calculate(20, 8);
        WriteLine($"Suma: {sum}, Resta: {substract}");
    }

    static (int Sum, int Substract) Calculate(int a, int b)
    {
        return (a + b, a - b);
    }

}