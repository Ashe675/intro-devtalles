partial class Program
{
    static void FileExample()
    {

        string filePath = "./05-Files/Example.txt";

        var content = File.ReadAllText(filePath);

        // WriteLine(content);

        var linea = File.ReadAllLines(filePath);

        foreach (var line in linea)
        {
            WriteLine(line);
        }

        File.Copy("./05-Files/Example.txt", "./05-Files/Example2.txt", overwrite: true);
        File.Delete("./05-Files/Example2.txt");

    }
}