partial class Program
{
    // * Condicionales: if, else if, else, switch, operador ternario
    static void Conditionals()
    {
        int number = 10;

        if (number > 0)
        {
            WriteLine("El número es positivo.");
        }
        else if (number < 0)
        {
            WriteLine("El número es negativo.");
        }
        else
        {
            WriteLine("El número es cero.");
        }

        string dayOfWeek = "Monday";

        switch (dayOfWeek)
        {
            case "Monday":
                WriteLine("Hoy es lunes.");
                break;
            case "Tuesday":
                WriteLine("Hoy es martes.");
                break;
            case "Wednesday":
                WriteLine("Hoy es miércoles.");
                break;
            case "Thursday":
                WriteLine("Hoy es jueves.");
                break;
            case "Friday":
                WriteLine("Hoy es viernes.");
                break;
            default:
                WriteLine("Es fin de semana.");
                break;
        }

        int age = 18;
        string canVote = age >= 18 ? "Sí, puedes votar." : "No, no puedes votar.";
        WriteLine(canVote);

        int day = 2;

        // * SWITCH EXPRESSION
        string dayType = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            _ => "Invalid Day"
        };

        WriteLine(dayType);
    }
}