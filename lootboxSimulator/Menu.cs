namespace lootboxSimulator;

public class Menu
{
    private Lootbox _lootbox = new Lootbox();
    public static Pouch _pouch = new Pouch();
    public void DisplayMenu()
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
                Console.WriteLine("\nOpening Lootbox...");
                _lootbox.OpenLootBox();
                break;
            case 2:
                Console.WriteLine("\nViewing Pouch...");
                Console.WriteLine("\nPouch Contents:");
                Console.WriteLine("------------------------");
                _pouch.ViewPouch(_pouch);
                break;
            case 3:
                if (_pouch._pouchItems.Count == 0)
                {
                    Console.WriteLine("Pouch is empty!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nDropping Items...");
                    _pouch.RemoveItem();
                    break;
                } 
            case 4:
                Console.WriteLine("\nThank you for rolling!");
                Environment.Exit(0);
                break;
        }
    }

}