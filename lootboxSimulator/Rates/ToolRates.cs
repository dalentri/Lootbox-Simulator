using lootboxSimulator.Enums;

namespace lootboxSimulator.Rates;

public class ToolRates
{
    public Dictionary<LootboxItem, int> _itemRates = new Dictionary<LootboxItem, int>
    {
        { LootboxItem.Sword, 10 },
        { LootboxItem.Bow, 10 },
        { LootboxItem.Dagger, 10 },
        { LootboxItem.Staff, 10 },
        { LootboxItem.Wand, 10 },
        { LootboxItem.Axe, 10 },
        { LootboxItem.Mace, 10 },
        { LootboxItem.Hammer, 10 },
        { LootboxItem.Ring, 10 },
        { LootboxItem.Armor, 10 },
    };
}