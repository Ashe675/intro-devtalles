partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/Example.txt";
        var fileName = Path.GetFileName(filePath);
        var fileExtension = Path.GetExtension(filePath);
        var fileDirectory = Path.GetDirectoryName(filePath);
        WriteLine($"Nombre del archivo: {fileName}");
        WriteLine($"Extensión del archivo: {fileExtension}");
        WriteLine($"Directorio del archivo: {fileDirectory}");
        var combinedPath = Path.Combine(fileDirectory, fileName);
        WriteLine($"Ruta combinada: {combinedPath}");
        var fullFilePath = Path.GetFullPath(filePath);
        WriteLine($"Ruta completa: {fullFilePath}");
        
    }
}