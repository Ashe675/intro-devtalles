
partial class Program
{
    static void Convertions()
    {
        int number = 42;
        double decimalNumber = number;
        WriteLine(decimalNumber);

        double explicitDecimalNumber = 45.5;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine(integerNumber);

        //* Parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        //* Convert
        double anotherDecimal = 67.89;
        int convertedNumber = Convert.ToInt32(anotherDecimal);
        WriteLine(convertedNumber); // REDONDEAR

        int castedNumber = (int) anotherDecimal;
        WriteLine(castedNumber); // TRUNCAR

        
    }
}