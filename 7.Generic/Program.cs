using System;

public class GenericList<T>
{
    private T[] _items;
    private int _currentIndex;

    public GenericList(int capacity)
    {
        _items = new T[capacity];
        _currentIndex = 0;
    }

    public void Add(T item)
    {
        if (_currentIndex < _items.Length)
        {
            _items[_currentIndex] = item;
            _currentIndex++;
        }
        else
        {
            Console.WriteLine("List is full. Cannot add more items.");
        }
    }

    public void PrintItems()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a list of integers
        GenericList<int> intList = new GenericList<int>(5);
        intList.Add(10);
        intList.Add(20);
        intList.Add(30);
        intList.PrintItems();

        // Creating a list of strings
        GenericList<string> stringList = new GenericList<string>(3);
        stringList.Add("Hello");
        stringList.Add("World");
        stringList.PrintItems();
    }
}
