
partial class Program
{
    public static void Inheritance()
    {
        HogwartsStudent student = new() { House = "Gryffindor", Name = "Harry Potter" };
        student.Greet();
        student.ShowHouse();

        HogwartsProffesor professor = new() { Subject = "Potions", Name = "Severus Snape" };
        professor.Greet();
        professor.ShowMySubject();
    }


    class Character
    {
        public string? Name { get; set; }
        public virtual void Greet()
        {
            WriteLine($"Hola soy {Name}");
        }

    }

    class HogwartsStudent : Character
    {
        public string? House { get; set; }

        public override void Greet()
        {
            WriteLine($"Hola soy {Name} y pertenezco a la casa {House} en Hogwarts");
        }

        public void ShowHouse()
        {
            WriteLine($"Pertenezco a la casa {House} en Hogwarts");
        }

    }

    class HogwartsProffesor : Character
    {
        public string? Subject { get; set; }

        public override void Greet()
        {
            WriteLine($"Hola soy {Name} y enseño el {Subject} en Hogwarts");
        }

        public void ShowMySubject()
        {
            WriteLine($"Enseño el {Subject} en Hogwarts");
        }
    }
}