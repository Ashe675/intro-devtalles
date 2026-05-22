
// 🏆 Ejercicio:
// Crear un método llamado `PrintFactorialTable` que reciba un número 
// y muestre el factorial de todos los números desde 1 hasta el número ingresado.
// Ejemplo: PrintFactorialTable(5);
// 1! = 1
// 2! = 2
// 3! = 6
// 4! = 24
// 5! = 120
partial class Program
{
  

  static void FactorialTable()
  {
    Write("Ingresa un número para calcular su tabla de factoriales: ");
    string? input = ReadLine();
    if(!int.TryParse(input, out int number))
    {
        WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
        return;
    }

    PrintFactorialTable(number);
  }

  static void PrintFactorialTable(int number)
  {
    int total = 1;
    for (int i = 1; i <= number; i++)
    {
      total = total * i;
      WriteLine($"{i}! = {total}");
    }
  }
}