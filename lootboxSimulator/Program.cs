using System;
using System.Collections.Generic;
using System.Text;

namespace lootboxSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lootbox Simulator!\n");
            
            while (true)
            {
                Menu.DisplayMenu();
            }
            
        }
    }
}