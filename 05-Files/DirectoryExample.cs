partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files";

        Directory.CreateDirectory($"{directoryPath}/DirExample/OtherDir");


        if (Directory.Exists(directoryPath))
        {
            WriteLine("El directorio existe");
        }
        if (Directory.Exists($"{directoryPath}/DirExample/OtherDir"))
        {
            Directory.Delete($"{directoryPath}/DirExample/OtherDir", recursive: true);
        }
        else
        {
            WriteLine("El directorio no existe ");
        }
    }
}