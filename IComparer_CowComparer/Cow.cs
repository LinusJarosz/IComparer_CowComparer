namespace IComparer_CowComparer;

public class Cow : IEquatable<Cow>
{
    public string Name { get; }
    public string Colour { get; }
    public int Age { get; }

    public Cow(string name, string colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }

    public int GetHashCode() => HashCode.Combine(Name, Colour, Age);
    public bool Equals(Cow? other)
    {
        if (ReferenceEquals(this, other)) return true;
        if (ReferenceEquals(null, other)) return false;
        return Name.Equals(other.Name) && Colour.Equals(other.Colour) && Age.Equals(other.Age);
    }
}