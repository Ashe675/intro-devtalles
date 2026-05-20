// 🏆 Ejercicio:
// Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
// Consideraciones:
// - La fecha de nacimiento ingresada debe ser interpretada correctamente, 
//   asegurando que las comparaciones de fechas no sean afectadas por las horas.
// - Investigar acerca de `CultureInfo.InvariantCulture` para que no afecte la configuración regional del sistema.
// - Se debe manejar el caso en que el cumpleaños ya haya pasado en el año actual, 
//   sumando un año para calcular la fecha del próximo (opcional).

using System.Globalization;

partial class Program
{
    static void DaysUntilNextBirthday()
    {
        Console.Write("Ingrese su fecha de nacimiento en formato MM/dd/yyyy: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input) ||
            !DateTime.TryParseExact(input.Trim(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
        {
            Console.WriteLine("FECHA MAL INGRESADA");
            return;
        }
        Console.WriteLine($"Fecha de nacimiento ingresada: {birthDate}");

        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

        if(nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        TimeSpan timeUntilBirthday = nextBirthday - today;
        Console.WriteLine($"Faltan {timeUntilBirthday.Days} días para tu próximo cumpleaños.");

    }
}