namespace newStart;

public static class Sorters<T>
{
    public static IEnumerable<T> Order(IEnumerable<T> list)
    {
        T smollestItem = null;
        IEnumerable<T> tmpIn = list;
        IEnumerable<T> tmpOut = list;

        foreach (T item in tmpIn)
        {
            if (smollestItem is null) smollestItem = item;
            if (smollestItem > item)
        }
        return null;
    }
}
