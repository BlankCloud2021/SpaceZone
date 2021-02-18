using System;
using System.Collections.Generic;


namespace SpaceGameProject
{
    
    public class Script
    {
       
        public void Rules()
        {
            //Write all the rules settings and opjectives
        }
            public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Welcome to the Space Game! ");
            Console.WriteLine();

            Console.WriteLine("This Story is set on an apocalyptic planet called Earth in 3021. With only 5,000 days  until the planets\n demise, you are an Elemental Merchant task Traveling the 5 worlds known to man buying and selling\n goods. Your goal is to buy 2 Gas crystals and return to earth to secure the earths survival.");
            Console.WriteLine();

            Console.WriteLine("Your journey begins enter the name of your Ship");
            Console.WriteLine();

            Console.Write("Your Ship Name:");
        }


        
           public void WelcomeShip(string name)
        {
            Console.WriteLine($"Welcome Home! On This day {DateTime.Today} We christen this vessel The {name} to the Galaxy");
        }
        
            //Console.WriteLine("Days Remaining: XX");
            //Console.WriteLine();

        public void MainMenu(int fuel = 0, int days = 0)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("***************** Main Menu *******************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Fuel Level:{fuel}        Days Remaining:{days}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tCheck Inventory    (2)\tStore Inventory");
            Console.WriteLine();
            Console.WriteLine("(3)\tSelect Destination (4)\tUpgrades");
            Console.WriteLine("(0)\tQuit");
        }
        
        public void InventoryScript()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Items in Inventory                       Quantity ");
            Console.WriteLine("--------------------------------------------------");
        }
        
        public void StorageScript()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Items in Storage                               Quantity");
            Console.WriteLine("-------------------------------------------------------");
        }

        public void UpgradeScript(int maxInventory, int maxStorage, int maxFuel)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("************** Upgrade Station ****************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Max Fuel :{maxFuel}         Max Storage:{maxStorage}");
            Console.WriteLine($"Max Inventory{maxInventory}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tUpgrade Fuel     (2)\tUpgrade Storage ");
            Console.WriteLine();
            Console.WriteLine("(3)\tUpgrade Inventory     (0)\tQuit");
            
        }

    }
            /*
            Console.WriteLine("(1)\tCheck Inventory\n(2)\tStore Inventory\n(3)\tSelect Destination\n(4)\tSave\n(0)\tQuit");
            Console.WriteLine();

            Console.WriteLine("What Planet to travel\n(1)\tMars\n(2)\tSun\n(3)\tJupiter\n(4)\tPluto");
            Console.WriteLine();

            Console.WriteLine("Sorry on your journey to (Planet) You suffered from acute death.");
            Console.WriteLine();

            Console.WriteLine("Welcome to {Planet} My name is {Merchant}\n I am {Characteristics} So watch yourself.\n(1)\tWhat Cha buying\n(2)\tWhat cha Selling");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Item for sale                           Price ");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("(1)\tEarth Crystal                       $200\n(2)\tHeat Crystal                        $300\n(3)\tIce Crystal                         $200\n(4)\tGas Crystal                         $300\n(5)\tWater Crystal                       $200");

            Console.WriteLine("Money in your wallet: $XX");
            Console.WriteLine();


            Console.WriteLine("10 Days remain\nDawn of the final Day");
            Console.WriteLine();
        */
    
}
