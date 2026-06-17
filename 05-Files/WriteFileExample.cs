partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/WriteExample.txt";
        var content = "Podemos escribir en un archivo";
        var streamWriter = new StreamWriter(filePath, append: true);
        streamWriter.WriteLine(content);
        streamWriter.WriteLine("La hora atras es: " + DateTime.Now.ToString("HH:mm:ss"));
        streamWriter.Dispose();
    }
}