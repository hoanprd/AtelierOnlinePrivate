using System;
using System.Collections.Generic;
using System.Diagnostics;

public class BetterList<T> : IEnumerable<T>
{
    public delegate int CompareFunc(T left, T right);

    public T[] buffer;

    public int size;

    // Indexer cho phép truy xuất trực tiếp qua ngoặc vuông []
    public T this[int i]
    {
        get { return buffer[i]; }
        set { buffer[i] = value; }
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public IEnumerator<T> GetEnumerator()
    {
        if (buffer != null)
        {
            for (int i = 0; i < size; ++i)
            {
                yield return buffer[i];
            }
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private void AllocateMore()
    {
        T[] temp = buffer;
        int newSize = (buffer != null) ? buffer.Length << 1 : 32;
        buffer = new T[newSize];
        if (temp != null && size > 0)
        {
            Array.Copy(temp, 0, buffer, 0, size);
        }
    }

    private void Trim()
    {
        if (size == 0)
        {
            buffer = null;
        }
        else if (buffer == null || buffer.Length != size)
        {
            T[] temp = new T[size];
            for (int i = 0; i < size; ++i) temp[i] = buffer[i];
            buffer = temp;
        }
    }

    public void Clear()
    {
        size = 0;
    }

    public void Release()
    {
        size = 0;
        buffer = null;
    }

    public void Add(T item)
    {
        if (buffer == null || size == buffer.Length)
        {
            AllocateMore();
        }
        buffer[size++] = item;
    }

    public void Insert(int index, T item)
    {
        if (buffer == null || size == buffer.Length)
        {
            AllocateMore();
        }

        if (index > -1 && index < size)
        {
            Array.Copy(buffer, index, buffer, index + 1, size - index);
            buffer[index] = item;
            ++size;
        }
        else
        {
            buffer[size++] = item;
        }
    }

    public bool Contains(T item)
    {
        if (buffer == null) return false;
        for (int i = 0; i < size; ++i)
        {
            if (buffer[i].Equals(item)) return true;
        }
        return false;
    }

    public int IndexOf(T item)
    {
        if (buffer == null) return -1;
        for (int i = 0; i < size; ++i)
        {
            if (buffer[i].Equals(item)) return i;
        }
        return -1;
    }

    public bool Remove(T item)
    {
        if (buffer != null)
        {
            for (int i = 0; i < size; ++i)
            {
                if (buffer[i].Equals(item))
                {
                    --size;
                    buffer[i] = default(T);
                    for (int b = i; b < size; ++b) buffer[b] = buffer[b + 1];
                    buffer[size] = default(T);
                    return true;
                }
            }
        }
        return false;
    }

    public void RemoveAt(int index)
    {
        if (buffer != null && index > -1 && index < size)
        {
            --size;
            buffer[index] = default(T);
            for (int b = index; b < size; ++b) buffer[b] = buffer[b + 1];
            buffer[size] = default(T);
        }
    }

    public T Pop()
    {
        if (buffer != null && size > 0)
        {
            T item = buffer[--size];
            buffer[size] = default(T);
            return item;
        }
        return default(T);
    }

    public T[] ToArray()
    {
        Trim();
        return buffer;
    }

    [DebuggerHidden]
    [DebuggerStepThrough]
    public void Sort(CompareFunc comparer)
    {
        bool changed = true;
        while (changed)
        {
            changed = false;
            for (int i = 1; i < size; ++i)
            {
                if (comparer(buffer[i - 1], buffer[i]) > 0)
                {
                    T temp = buffer[i];
                    buffer[i] = buffer[i - 1];
                    buffer[i - 1] = temp;
                    changed = true;
                }
            }
        }
    }
}