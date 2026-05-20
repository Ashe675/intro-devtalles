
partial class Program
{
    static void ShowTime()
    {
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine($"Fecha y hora actual: {currentDateTime}");

        DateTime today = DateTime.Today;
        Console.WriteLine($"Fecha actual sin hora: {today}");

        DateTime specificDate = new DateTime(2024, 12, 25);
        Console.WriteLine($"Fecha específica: {specificDate}");

        DateTime tomorrow = currentDateTime.AddDays(1);
        Console.WriteLine($"Mañana será: {tomorrow}");

        TimeSpan timeDifference = specificDate - currentDateTime;
        Console.WriteLine($"Días hasta Navidad: {timeDifference.Days}");
        Console.WriteLine($"Meses hasta Navidad: {timeDifference.Days / 30}");

        DateTime nowWeekAgo = currentDateTime.AddDays(-7);
        Console.WriteLine($"Hace una semana era: {nowWeekAgo.ToShortDateString()}");
        DayOfWeek dayOfWeek = currentDateTime.DayOfWeek;
        Console.WriteLine($"Hoy es: {dayOfWeek}");
        string formattedDate = currentDateTime.ToString("dd/MM/yyyy");
        Console.WriteLine($"Fecha formateada: {formattedDate}");
    }
}