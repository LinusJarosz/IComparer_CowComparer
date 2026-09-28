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
        Console.WriteLine("=======================");
        List<Cow> cowInventory = new List<Cow>();
        using (StreamReader sR = new StreamReader("cowInventory.txt"))
        {
            while (!sR.EndOfStream)
            {
                string line = sR.ReadLine();
                if 
                (
                    line.Split(';').Length == 3 &&
                    line.Substring(0, 2) != "//" &&
                    line.Substring(0, 2) != "/*" &&
                    !String.IsNullOrWhiteSpace(line.Split(';')[0]) &&
                    int.TryParse(line.Split(';')[2], out int alter) &&
                    alter >= 0 &&
                    alter <= 48 &&
                    Colour.TryParse(line.Split(';')[1], out Colour colour)
                )
                {
                    cowInventory.Add(new Cow(line.Split(';')[0], colour, alter));
                }
                else
                {
                    Console.WriteLine($"Konnte nicht als Cow erstellt werden: {line}");
                }
            }
        }
        foreach(Cow cow in cowInventory) Console.WriteLine(cow);
    }
}