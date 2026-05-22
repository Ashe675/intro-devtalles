using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-HN");

        string dateString = "2024-06-15";
        DateTime date = DateTime.Parse(dateString);
        WriteLine($"Fecha convertida: {date.ToShortDateString()}");

        string timeString = "14:30";
        TimeSpan time = TimeSpan.Parse(timeString);
        WriteLine($"Hora convertida: {time}");
        

        int friends = int.Parse("101");
        double cost = 25.50;
        DateTime birthday = DateTime.Parse("2 Marzo 2025");
        WriteLine($"Cumpleaños: {birthday}");
        WriteLine($"Fromato largo: {birthday:D}");
        WriteLine($"Número de amigos: {friends}");
        WriteLine($"Costo total: {cost:C}");
        


    }
}