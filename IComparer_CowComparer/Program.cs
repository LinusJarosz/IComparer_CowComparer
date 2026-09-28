namespace IComparer_CowComparer;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows =
        [
            new Cow("Milka", "lila", 4),
            new Cow("Paula", "weiss", 6),
            new Cow("Conny", "schwarz", 4),
            new Cow("Berta", "weiss", 7),
            new Cow("Mathias", "rosa", 4),
            new Cow("Milka", "rosa", 4),
            new Cow("Milka", "lila", 5)
        ];
        cows.Sort();
        foreach(Cow cow in cows) Console.WriteLine(cow);
        Console.WriteLine("------------------");
        cows.Sort(new AgeComparer());
        foreach(Cow cow in cows) Console.WriteLine(cow);
        Console.WriteLine("------------------");
        cows.Sort(new NameLengthComparer());
        foreach(Cow cow in cows) Console.WriteLine(cow);

    }
}