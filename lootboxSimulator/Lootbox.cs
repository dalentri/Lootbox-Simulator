using lootboxSimulator.Enums;
using lootboxSimulator.Rates;

namespace lootboxSimulator;

public class Lootbox
{
    Random _random = new Random(); // Initialize Random
    
    // Initialize Rate classes
    ToolRarityRates _toolRarityRates = new ToolRarityRates();
    ToolRates _toolRates = new ToolRates();
    LootboxRarityRates _lootboxRarityRates = new LootboxRarityRates();
    
    public LootboxItem RollTool()
    {
        int roll = _random.Next(1, 101);
        
        // Console.WriteLine($"Roll: {roll}"); // debug
        
        LootboxItem rolledTool = default;
        
        int cumulativePercentage = 0;
        
        foreach (var tool in _toolRates._itemRates)
        {
            cumulativePercentage += tool.Value;
            // Console.WriteLine($"Cumulative percentage: {cumulativePercentage}, Tool: {tool.Key}"); // cumulative% debug
            if (roll <= cumulativePercentage)
            {
                rolledTool = tool.Key;
                break;
            }
        }

        // Console.WriteLine($"Tool rolled: {rolledTool}"); // debug
        
        return rolledTool;
    }


    //Rolls rarity of the tool
    public LootRarityType RollToolRarity()
    {
        int roll = _random.Next(1, 101); //Generates a random number 1-100
        
        // Console.WriteLine($"Roll: {roll}"); // debug

        LootRarityType rolledToolRarity = default; // Initializes the rolled tool rarity variable
        
        int cumulativePercentage = 0;

        foreach (var rarity in _toolRarityRates.ToolRarityRate)
        {
            cumulativePercentage += rarity.Value;
            // Console.WriteLine($"Cumulative percentage: {cumulativePercentage}, Rarity: {rarity.Key}"); // cumulative% debug
            if (roll <= cumulativePercentage)
            {
                rolledToolRarity = rarity.Key;
                break;
            }
        }
        
        // Console.WriteLine($"Tool rarity: {rolledToolRarity}"); // debug

        return rolledToolRarity;
    }

    public void OpenLootBox()
    {
        Console.WriteLine("Lootbox opened!\n");

        LootRarityType latestToolRarityRoll = RollToolRarity();
        LootboxItem latestToolRoll = RollTool();
        string latestDrop = latestToolRarityRoll.ToString() + " " + latestToolRoll.ToString();
        
        Console.WriteLine("You rolled a " + latestDrop + "!\n");

        Console.Write("Would you like to keep the item? (y/n): ");
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "y":
                Console.WriteLine("Item kept!");
                Menu._pouch.AddItem(latestDrop.ToString());
                break;
            case "n":
                Console.WriteLine("Item dropped!");
                break;
            default:
                Console.WriteLine("Invalid input, please input y or n!");
                break;
        }
    }
}

