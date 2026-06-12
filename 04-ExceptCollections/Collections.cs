partial class Program
{
    static void Collections()
    {
        List<string> names = ["Alice", "Bob", "Charlie"];
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        ShowArray(names);
        ShowArray(numbers);

        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Alice"] = 25;

        Dictionary<int, string> students = new()
        {
          {1, "Juan"},
          {2, "Maria"},
          {3, "Pedro"}
        };

        WriteLine(ages["Alice"]);
        WriteLine(students[1]);

        ShowDictionary(students);

        HashSet<string> colors = new HashSet<string>();
        colors.Add("Rojo");
        colors.Add("Azul");
        colors.Add("Verde");
        colors.Add("Rojo");
        ShowHashSet(colors);


    }

    private static void ShowHashSet<T>(HashSet<T> items)
    {
        foreach (var item in items)
        {
            WriteLine(item);
        }
    }


    private static void ShowDictionary<TKey, TValue>(Dictionary<TKey, TValue> items) where TKey : notnull
    {
        foreach (var item in items)
        {
            WriteLine($"{item.Key} - {item.Value}");
        }
    }

    private static void ShowArray<T>(List<T> names)
    {
        foreach (var name in names)
        {
            WriteLine(name);
        }
    }
}