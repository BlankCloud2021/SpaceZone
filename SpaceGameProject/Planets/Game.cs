using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Planets
{
    public class Game
    {
        Ship ship = new Ship();

        //Feilds

        public int daysRemaining { get; set; }

        public Game()
            {

            daysRemaining = 5000;

            }


        //Method

        public void ViewInventory()//might not need
        {
            // Prints to the screen items in the inventory

        }

        public void DisplayPlanet()
        {
            // Displays the planets buying menu
            //Create an instance of each planet in a switch statment to call there script and inventory

        }

        // Checks for deaths based on the in game Items
        public void CheckDeath(Goods[] inventory, Goods[] storage, Planets destination, int Days, int fuel)
        {
            //Takes in input and checks for all death conditions.
            //Switch statment with all deaths.3

            // Combustion Mercury
            if (destination == Planets.Mercury)
            {
                //If Gas crysatal in Inventory when traveling to
                int gasCount = 0;

                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == Goods.Gas_Crystal)
                    {
                        gasCount += 1;
                    }
                }
                if (gasCount > 0)
                {
                    Console.WriteLine("You Fool! You've Doomed us all bringing that Gas crystal here!");
                    Console.WriteLine("The planet exploded, You have died!");

                    ship.Continues();
                    Environment.Exit(0);
                }
            }

            //Combustion Jupiter
            if (destination == Planets.Jupitar)
            {
                //If Gas crysatal in Inventory when traveling to
                int heatCount = 0;

                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == Goods.Heat_Crystal)
                    {
                        heatCount += 1;
                    }
                }
                if (heatCount > 0)
                {
                    Console.WriteLine("You Fool! You've Doomed us all bringing that Heat crystal here!");
                    Console.WriteLine("The planet exploded, You have died!");

                    ship.Continues();
                    Environment.Exit(0);
                }
            }

            //Tank is Empty
            if (fuel < 0)
            {
                Console.WriteLine($"You've Run out of fuel trying to reach {destination}");
                Thread.Sleep(2000);
                Console.WriteLine("You've died alone in the void of space view the single picture of your family that remains.");
                Thread.Sleep(2000);
                Console.WriteLine("As you breath your last breath find peace");
                Thread.Sleep(2000);
                Console.WriteLine("Until you see a rescue ship apporaching in the distance and become in-raged in your final moments");
                Thread.Sleep(2000);
                ship.Continues();
                Environment.Exit(0);
            }

            //Earth Death
            // Runs through Inventory and Storage if the are 2 or more gas Crystal game will exit.
            if (Days <= 0)
            {
                int gasCount = 0;

                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == Goods.Gas_Crystal)
                    {
                        gasCount += 1;
                    }
                }

                for (int i = 0; i < storage.Length; i++)
                {
                    if (storage[i] == Goods.Gas_Crystal)
                    {
                        gasCount += 1;
                    }
                }

                if (gasCount < 2)
                {
                    Console.WriteLine("The Earth Has run out of oxegen, everyone you know and love is dead.");
                    Console.WriteLine("You Lose!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Ya Loser");
                    ship.Continues();
                    Environment.Exit(0);
                }
            }

        }

        // Checks Win Condition Input both inventories
        public void WinCondition(Goods[] inventory, Goods[] storage)
        {
            //Run win game, checked at Earth
            // Runs through Inventory and Storage if the are 2 or more gas Crystal game will exit.
            int gasCount = 0;

            for(int i= 0; i<inventory.Length; i++)
            {
                if (inventory[i] == Goods.Gas_Crystal)
                {
                    gasCount += 1;
                }
            }

            for (int i = 0; i < storage.Length; i++)
            {
                if (storage[i] == Goods.Gas_Crystal)
                {
                    gasCount += 1;
                }
            }

            if (gasCount >= 2)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("****************** You Win ********************");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Gongradulation You have saved the earth with your 2 gas crystals.");
                
                
                ship.Continues();
                Environment.Exit(0);
            }
        




        }





    }
}
