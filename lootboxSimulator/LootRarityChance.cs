namespace lootboxSimulator;

public class LootRarityChance
{
    Dictionary<LootRarity, int> _rarityChance = new Dictionary<LootRarity, int>
    {
        { LootRarity.Common, 50 },
        { LootRarity.Uncommon, 25 },
        { LootRarity.Rare, 15 },
        { LootRarity.Epic, 6 },
        { LootRarity.Legendary, 3 },
        { LootRarity.Mythic, 1 }
    };
    
}