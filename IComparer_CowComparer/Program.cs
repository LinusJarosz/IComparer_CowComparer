using System.Drawing;

namespace IComparer_CowComparer;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows =
        [
            new Cow("Milka", Colour.Lila, 4),
            new Cow("Paula", Colour.Weiß, 6),
            new Cow("Conny", Colour.Braun, 4),
            new Cow("Berta", Colour.Weiß, 7),
            new Cow("Mathias", Colour.Rosa, 4),
            new Cow("Milka", Colour.Rosa, 4),
            new Cow("Milka", Colour.Lila, 5)
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