using lootboxSimulator.Enums;

namespace lootboxSimulator.Rates;

public class ToolRarityRates
{
    public Dictionary<LootRarityType, int> ToolRarityRate { get; } = new Dictionary<LootRarityType, int>
    {
        {LootRarityType.Common, 40},
        {LootRarityType.Uncommon, 30},
        {LootRarityType.Rare, 20},
        {LootRarityType.Epic, 6},
        {LootRarityType.Legendary, 3},
        {LootRarityType.Mythic, 1}
    };
}