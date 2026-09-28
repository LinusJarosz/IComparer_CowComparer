namespace IComparer_CowComparer;

public class NameLengthComparer : IComparer<Cow>
{
    int IComparer<Cow>.Compare(Cow? x, Cow? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        return x.Name.Length.CompareTo(y.Name.Length);
    }
}