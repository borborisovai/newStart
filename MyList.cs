namespace newStart;
using System;
using System.Collections;
using System.Collections.Generic;

public class MyList<T> : ICollection<T>
{
    private int _count = 0;
    private int _vaultSize = 16;
    private T?[] _vault = new T[16];

    public T this[int index]{
        get => _vault[index];
        set => _vault[index] = value;
    }

    public void Add(T item)
    {
        if (Count >= _vaultSize) IncreeaseVaultSize();

        _vault[Count] = item;
        _count++;
    }

    public bool Contains(T item) => IndexOf(item) >= 0;

    private int IndexOf(T item)
    {
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        for (int i = 0; i < _count; i++)
        {
            if (comparer.Equals(_vault[i], item))
                return i;
        }

        return -1;
    }

    private void IncreeaseVaultSize()
    {
        T?[] newVault = new T[_vaultSize + 16];
        int c = 0;
        foreach (T? i in _vault)
        {
            newVault[c] = i;
            c++;
        }
        _vault = newVault;
    }

    public void Clear()
    {
        _vault = new T[16];
        _vaultSize = 16;
        _count = 0;
    }

    public int Count => _count;

    public bool IsReadOnly => false;

    public bool Remove(T item)
    {
        int c = 0;
        foreach (T? i in _vault)
        {
            if ((item is null && i is null) || (i is not null && i.Equals(item)))
            {
                RemoveAt(c);
                break;
            }
        }
        return true;
    }

    public bool RemoveAt(int index)
    {
        int c = index;
        while (c <= Count)
        {
            _vault[c] = _vault[c + 1];
            c++;
        }
        _vault[c] = default(T);
        return true;
    }

    public void CopyTo(T[] array, int index) {
        Array.Copy(_vault, 0, array, index, _count);
    }


    public IEnumerator<T> GetEnumerator() => new MyListEnumerator<T>(this);

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();



}

public class MyListEnumerator<T> : IEnumerator<T>
{
    private MyList<T> _list;
    private int _curIndex;
    private T _curItem;

    public MyListEnumerator(MyList<T> list)
    {
        _list = list;
        _curIndex = -1;
        _curItem = default(T);
    }

    public bool MoveNext()
    {
        if (++_curIndex >= _list.Count) return false;
        else _curItem = _list[_curIndex];
        return true;
    }

    public void Reset() { _curIndex = -1; }

    void IDisposable.Dispose() { }

    public T Current => _curItem;

    object IEnumerator.Current => _curItem;

}


