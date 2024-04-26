using System;
using System.Collections.Generic; // For List<T> (if not using ObservableCollection)

public class ToDoList
{
    private List<string> _items; // Or use ObservableCollection<string> for change notifications

    public ToDoList()
    {
        _items = new List<string>(); // Or use new ObservableCollection<string>()
    }

    public void AddItem(string item)
    {
        _items.Add(item);
    }

    public bool RemoveItem(int index)
    {
        if (index >= 0 && index < _items.Count)
        {
            _items.RemoveAt(index);
            return true;
        }
        return false;
    }

    public bool RemoveItem(string item)
    {
        return _items.Remove(item);
    }

    public void PrintList()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("Your to-do list is empty.");
            return;
        }

        Console.WriteLine("** To-Do List **");
        for (int i = 0; i < _items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_items[i]}");
        }
    }
}
