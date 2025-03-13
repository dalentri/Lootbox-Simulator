using System.Diagnostics;

namespace lootboxSimulator;

public class Pouch
{
    public List<String> _pouchItems = new List<String>();

    public void AddItem(String item)
    {
        _pouchItems.Add(item);
        Console.WriteLine("Pouch contents: " + _pouchItems.Count);
        
    }


    public void RemoveItem()
    {
        Console.WriteLine("Would you like to remove an item or clear the entire pouch?\n");
        Console.WriteLine("1. Clear pouch");
        Console.WriteLine("2. Remove an item");
        
        int userChoice = Convert.ToInt32(Console.ReadLine());
        
        if (userChoice == 1)
        {
            _pouchItems.Clear();
            
        } else if (userChoice == 2)
        {
            Console.WriteLine("What item would you like to remove?");

            for (var i = 0; i < _pouchItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_pouchItems[i]}");
            }

            int itemRemovalUserChoice = Convert.ToInt32(Console.ReadLine());
            itemRemovalUserChoice--;

            _pouchItems.Remove(_pouchItems[itemRemovalUserChoice]);
        }
        else
        {
            Console.WriteLine("Invalid input, please input 1 or 2!\n");
            RemoveItem();
        }
    }
    
    public void ViewPouch(Pouch pouch)
    {
        if (_pouchItems.Count == 0)
        {
            Console.WriteLine("Pouch is empty!\n");
            return;
        } else foreach (var item in _pouchItems)
        {
            Console.WriteLine(item);
        }
    }
}