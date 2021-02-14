using System;
using Planets;
namespace SpaceGameProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Script text = new Script();
            Ship ship = new Ship();
            Game game = new Game();

            //Main Menu
            //Welcomes player to adventure explains the rules And accpet a name for there ship.
            text.Rules();
            text.Welcome();

            ship.ShipName = Console.ReadLine().ToUpper();
            String Player = ship.DisplayShip();
            text.WelcomeShip(Player);
            ship.Continues();

            //Start The Menu And begin the game Loop should start here.

            text.MainMenu(ship.Fuel ,game.daysRemaining);
            int uInput = int.Parse( Console.ReadLine());

            switch (uInput)
            {
                case 1:
                    //Check player Inventory
                    ship.DisplayInventory();
                    break;

                case 2:
                    ship.StoredItems();
                    Console.WriteLine("Whould you like to store and item?\tYes/No");
                    if (Console.ReadLine().ToLower()== "yes")
                    {

                    }

                    break;

                case 3:

                    break;

                case 0:

                    break;
            }

        }
    }
}
