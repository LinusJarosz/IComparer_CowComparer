namespace IComparer_CowComparer;

public class AgeComparer : IComparer<Cow>
{
    public int Compare(Cow? x, Cow? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Age.CompareTo(y.Age);
    }
}