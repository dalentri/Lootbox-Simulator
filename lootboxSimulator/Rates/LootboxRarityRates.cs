using lootboxSimulator.Enums;

namespace lootboxSimulator.Rates;

public class LootboxRarityRates
{
    public static Dictionary<LootboxRarityType, int> lootboxRates = new Dictionary<LootboxRarityType, int>
    {
        { LootboxRarityType.CommonBox, 40 },
        { LootboxRarityType.UncommonBox, 25 },
        { LootboxRarityType.RareBox, 20 },
        { LootboxRarityType.EpicBox, 10 },
        { LootboxRarityType.LegendaryBox, 4 },
        { LootboxRarityType.MythicBox, 1 },
    };
    
}