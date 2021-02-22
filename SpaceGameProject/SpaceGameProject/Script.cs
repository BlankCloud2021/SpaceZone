using System;
using System.Collections.Generic;
using System.Threading;

namespace SpaceGameProject
{
    
    public class Script
    {
       
        public void Rules()
        {
        
        }
            public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string text = "Welcome to the Space Game! ";
            string text2 = "This Story is set on an apocalyptic planet called Earth in 3021. With only 5,000 days  until the planets\n demise, you are an Elemental Merchant task Traveling the 5 worlds known to man buying and selling\n goods. Your goal is to buy 2 Gas crystals and return to earth to secure the earths survival.\n Be warned certain aspects of the day will spell your doom!";
            foreach (char Text in text)
            {
                Console.Write(Text);
                Thread.Sleep(100);
            }
            
            Console.WriteLine();
            Thread.Sleep(2000);

            foreach (char Text in text2)
            {
                Console.Write(Text);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Press any Key to Continue");
            Console.ReadKey();

            Console.Clear();

            string text3 = "Your journey begins enter the name of your Ship";
            foreach (char Text in text3)
            {
                Console.Write(Text);
                Thread.Sleep(50);
            }
            Console.WriteLine();
           
            Console.Write("Your Ship Name:");
        }


        
           public void WelcomeShip(string name)
        {
            Console.WriteLine($"Welcome Home! On This day {DateTime.Today} We christen this vessel The {name} to the Galaxy");
        }
        

        public void MainMenu(int fuel = 0, int days = 0, int wallet = 0)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("***************** Main Menu *******************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Fuel Level:{fuel}        Days Remaining:{days}");
            Console.WriteLine();
            Console.WriteLine($"           Current Funds:{wallet:C}             ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tCheck Inventory    (2)\tStore Inventory");
            Console.WriteLine();
            Console.WriteLine("(3)\tSelect Destination (4)\tUpgrades");
            Console.WriteLine("(5)\tFuel Refill        (0)\tQuit");
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

        public void UpgradeScript(int maxInventory, int maxStorage, int maxFuel, int wallet)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("************** Upgrade Station ****************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Max Fuel:{maxFuel}           Max Storage:{maxStorage}");
            Console.WriteLine($"Max Inventory:{maxInventory} Current Funds:{wallet:C}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tUpgrade Fuel       $300   (2)\tUpgrade Storage  $300 ");
            Console.WriteLine();
            Console.WriteLine("(3)\tUpgrade Inventory  $300   (0)\tQuit ");
            Console.WriteLine();
            
        }

        public void PlanetMenu(int fuel, int days)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("***************** Plant Menu *******************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Fuel Level:{fuel}        Days Remaining:{days}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tEarth    (2)\tPluto");
            Console.WriteLine();
            Console.WriteLine("(3)\tMercury  (4)\tMars");
            Console.WriteLine();
            Console.WriteLine("(5)\tJupitar  (0)\tQuit");
        }

    }
            /*
           

            

            Console.WriteLine("Sorry on your journey to (Planet) You suffered from acute death.");
            Console.WriteLine();

            

           

            Console.WriteLine("(1)\tEarth Crystal                       $200\n(2)\tHeat Crystal                        $300\n(3)\tIce Crystal                         $200\n(4)\tGas Crystal                         $300\n(5)\tWater Crystal                       $200");

            Console.WriteLine("Money in your wallet: $XX");
            Console.WriteLine();


            Console.WriteLine("10 Days remain\nDawn of the final Day");
            Console.WriteLine();
        */
    
}
