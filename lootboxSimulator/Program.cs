
namespace lootboxSimulator
{
    class Program
    {
        static Menu _menu = new Menu();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lootbox Simulator!\n");

            while (true)
            {
                _menu.DisplayMenu();
            }
        }
    }
}