partial class Program
{
    static void SalaryCalculator()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("CALCULADORA DE SALARIO");
        Console.WriteLine("----------------------------------------");
        Console.Write("Ingrese su nombre: ");
        string? inputName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputName))
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            return;
        }

        Console.Write("Ingrese las horas trabajadas: ");
        string? inputHours = Console.ReadLine();

        if (!double.TryParse(inputHours, out double hoursWorked))
        {
            Console.WriteLine("Horas trabajadas no válidas.");
            return;
        }

        Console.Write("Ingrese el pago por hora: ");
        string? inputHourlyRate = Console.ReadLine();

        if (!decimal.TryParse(inputHourlyRate, out decimal hourlyRate))
        {
            Console.WriteLine("Pago por hora no válido.");
            return;
        }

        decimal totalSalary = (decimal)hoursWorked * hourlyRate;
        Console.WriteLine($"El salario mensual total de {inputName} es: {totalSalary:C}");

    }
}