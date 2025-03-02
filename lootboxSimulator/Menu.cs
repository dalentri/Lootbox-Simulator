namespace lootboxSimulator;

public class Menu
{
    public static void DisplayMenu()
    {
        int choice;
        
        // Display menu
        Console.WriteLine("Menu:");
        Console.WriteLine("-------------------");
        Console.WriteLine("1. Open Loot box");
        Console.WriteLine("2. View Pouch");
        Console.WriteLine("3. Drop Items");
        Console.WriteLine("4. Exit");
        
        Console.Write("\nEnter your choice: ");
        
        // Validate user input
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
           Console.WriteLine("\nInvalid input, please input a valid choice.");
           Console.Write("Enter your choice: ");
        }
        
        // Store user's choice
        int userMenuChoice = choice; 
        
        // Perform action based on user's choice
        switch (userMenuChoice)
        {
            case 1:
                Console.WriteLine("Opening Lootbox...");
                break;
            case 2:
                Console.WriteLine("Viewing Pouch...");
                break;
            case 3:
                Console.WriteLine("Dropping Items...");
                break;
            case 4:
                Console.WriteLine("Thank you for rolling!");
                Environment.Exit(0);
                break;
        }
    }

}