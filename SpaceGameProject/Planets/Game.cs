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

     
        public void CheckDeath(Goods[] inventory, Goods[] storage, Planets destination, int Days, int fuel)
        {

            // Combustion Mercury
            if (destination == Planets.Mercury)
            {
                
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
                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ForegroundColor = ConsoleColor.Red;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The Earth Has run out of oxegen, everyone you know and love is dead.");
                    Console.WriteLine("You Lose!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Ya Loser");
                    ship.Continues();
                    Environment.Exit(0);
                }
            }

        }

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
                ship.AssciartWin();
                //Console.WriteLine("-----------------------------------------------");
                //Console.WriteLine("****************** You Win ********************");
                //Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Gongradulation You have saved the earth with your 2 gas crystals.");
                
                
                ship.Continues();
                Environment.Exit(0);
            }
        




        }





    }
}
