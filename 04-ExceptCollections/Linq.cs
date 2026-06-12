
partial class Program
{
    static void Linq()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // * Sintaxis de metodo
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        evenNumbers.Where(delegate (int x)
        {
            return true;
        });
        WriteLine("Números pares:");
        foreach (var num in evenNumbers)
        {
            WriteLine(num);
        }

        // * Sintaxis de consulta
        var evenNumbersQuery = from number in numbers
                               where number % 2 == 0
                               select number;
        WriteLine("Números pares:");
        foreach (var num in evenNumbersQuery)
        {
            WriteLine(num);
        }

        // * CONSULTAS SIMPLES

        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
        new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
        new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
        new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
        new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };
        var avengersvcharacters = characters.Where(x => x.Team == "Avengers");
        foreach (var item in avengersvcharacters)
        {
            WriteLine($"{item.Name} - {item.Alias}");
        }

        var avengersCharactersQuery = from character in characters
                                       where character.Team == "Avengers"
                                       select $"{character.Name} - {character.Alias}";
        WriteLine("Personajes de los Avengers:");
        foreach (var item in avengersCharactersQuery)
        {
            WriteLine(item);
        }

        var uppercaseNamesQuery = from character in characters
                                  select character.Name?.ToUpper();
        WriteLine("Nombres en mayúsculas:");
        foreach (var item in uppercaseNamesQuery)
        {
            WriteLine(item);
        }

        var uppercaseNamesMethod = characters.Select(x => x.Name?.ToUpper());
        WriteLine("Nombres en mayúsculas:");
        foreach (var item in uppercaseNamesMethod)
        {
            WriteLine(item);
        }
    }

    class MarvelCharacter
    {
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }

}