namespace IComparer_CowComparer;

public class Cow : IEquatable<Cow>, IComparable<Cow>
{
    public string Name { get; }
    public Colour Colour { get; }
    public int Age { get; }

    public Cow(string name, Colour colour, int age)
    {
        Name = name;
        Colour = colour;
        Age = age;
    }

    public override string ToString() => $"{Name}; {Colour}; {Age} ";

    public int GetHashCode() => HashCode.Combine(Name, Colour, Age);
    public bool Equals(Cow? other)
    {
        if (ReferenceEquals(this, other)) return true;
        if (ReferenceEquals(null, other)) return false;
        return Name.Equals(other.Name) && Colour.Equals(other.Colour) && Age.Equals(other.Age);
    }

    public int CompareTo(Cow? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other == null) return 1;
        return Name.CompareTo(other.Name) != 0? Name.CompareTo(other.Name) :
            Colour.CompareTo(other.Colour) != 0?  Colour.CompareTo(other.Colour) :
            Age.CompareTo(other.Age);
    }
}