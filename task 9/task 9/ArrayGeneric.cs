using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class ArrayGeneric<T> where T : Human
{
    private T[] _array = Array.Empty<T>();

    public T this[int index]
    {
        get
        {
            return _array[index];
        }
        set
        {
            _array[index] = value;
        }
    }

    public int Count()
    {
        return _array.Length;
    }

    public void Add(T value)
    {
        var newArray = new T[_array.Length + 1];
        for (int i = 0; i < _array.Length; i++)
        {
            newArray[i] = _array[i];
        }
        newArray[_array.Length] = value;
        _array = newArray;
    }

    public void RemoveAt(int index)
    {
        var arrayRemove = new T[_array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            arrayRemove[i] = _array[i];
        }

        for (int i = index + 1; i < _array.Length; i++)
        {
            arrayRemove[i - 1] = _array[i];
        }

        _array = arrayRemove;
    }

    public void ToString()
    {
        int countWomen = 0;
        int countMen = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] is Woman)
            {
                countWomen++;
            }

            if (_array[i] is Man)
            {
                countMen++;
            }

            Console.WriteLine($"{_array[i].FirstName} {_array[i].LastName}");
        }

        if (countWomen == _array.Length)
        {
            Console.WriteLine("There’re only women");
        }

        if (countMen == _array.Length)
        {
            Console.WriteLine("There’re only men");
        }
    }
}

