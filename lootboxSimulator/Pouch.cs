using System.Collections;

namespace lootboxSimulator;

public class Pouch
{
    public List<LootItem> PouchItems = new List<LootItem>();
    
    public void AddItem(LootItem item)
    {
        PouchItems.Add();
    }

    public void RemoveItem(LootItem item)
    {
        PouchItems.Remove();
    }
    
    public void ViewPouch()
    {
        foreach (var item in PouchItems)
        {
            Console.WriteLine(item);
        }
    }
}