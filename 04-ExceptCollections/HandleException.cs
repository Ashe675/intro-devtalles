using System.IO.Pipelines;

partial class Program
{

    static void HandleExcepcions()
    {

        string amount = "";
        // int number = 10;

        try
        {
            // int result = number / 0;
            // WriteLine(result);
            amount = "33";
            if (string.IsNullOrEmpty(amount)) return;
            double amountValue = double.Parse(amount);
            WriteLine(amountValue);
            ValidateAge(-5);
            return;
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("No se puede dividir entre cero");
        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            WriteLine("No es necesario el simbolo $");
        }
        catch (System.Exception ex)
        {
            WriteLine($"Error jajja {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
            WriteLine("SE EJECUTO EL FINALLY");
        }



        WriteLine("Fin del programa");

    }


    static int ValidateAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("La edad no puede ser negativa");
        }
        return age;
    }
}