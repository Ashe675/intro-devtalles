partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Bosque");
        animal.Species = "Lobo";
        animal.Age = 3;
        WriteLine($"Donde vive: {animal.Habitat}");
        WriteLine($"Especie: {animal.Species}");
        WriteLine($"Edad: {animal.Age}");
        WriteLine($"Categoria: {animal.Category}");
    }
}


class Animal
{
    public string Species { get; set; } = "Unknown";
    public string Category { get; } = "Vertebrados";

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa");
            }
            age = value;
        }
    }

    public string Habitat { get; }

    public Animal(string habitat)
    {
        Habitat = habitat;
    }

}