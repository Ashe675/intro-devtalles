// 🏆 Ejercicio:
// Implementar un programa que recorra los números del 1 al 100.
// Consideraciones:
// Aplicar la lógica de FizzBuzz:
// - Si un número es divisible por 3, imprimir "Fizz".
// - Si un número es divisible por 5, imprimir "Buzz".
// - Si un número es divisible por 3 y 5, imprimir "FizzBuzz".
// - En cualquier otro caso, imprimir el número.
// 💡 Pista:
// - El orden de las condiciones es clave.
// Piensa en cómo asegurarte de que "FizzBuzz" se imprima antes que "Fizz" o "Buzz".

partial class Program
{
    static void FizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            string result = "";

            if (i % 3 == 0)
            {
                result += "Fizz";
            }

            if (i % 5 == 0)
            {
                result += "Buzz";
            }

            WriteLine(string.IsNullOrEmpty(result) ? i : result);
        }
    }
}
