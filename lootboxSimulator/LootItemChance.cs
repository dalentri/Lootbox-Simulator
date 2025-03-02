namespace lootboxSimulator;

public class LootItemChance
{
    private Dictionary<LootItems, double> _itemChance = new Dictionary<LootItems, double>
    {
        { LootItems.Sword, 0.1 },
        { LootItems.Bow, 0.1 },
        { LootItems.Dagger, 0.1 },
        { LootItems.Staff, 0.1 },
        { LootItems.Wand, 0.1 },
        { LootItems.Axe, 0.1 },
        { LootItems.Mace, 0.1 },
        { LootItems.Hammer, 0.1 },
        { LootItems.Ring, 0.1 },
        { LootItems.Armor, 0.1 }
    };

}
