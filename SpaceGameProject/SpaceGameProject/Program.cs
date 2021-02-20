using System;
using Planets;

namespace SpaceGameProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool condition = true;
            
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
            
                do
                {
                int uInput = 0;
                bool x = true;
                while (x)
                {
                    try
                    {
                        text.MainMenu(ship.Fuel, game.daysRemaining);
                        Console.WriteLine("What would you like to do?");
                        uInput = int.Parse(Console.ReadLine());
                        x = false;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid menu option.");
                        ship.Continues();
                        x = true;
                    }
                    
                }
                
                    switch (uInput)
                    {
                        case 1:
                            //Check player Inventory
                            text.InventoryScript();
                            ship.DisplayInventory();

                            ship.Continues();
                            break;

                        case 2:
                            text.StorageScript();
                            ship.StoredItems();
                        try
                        {
                            Console.WriteLine("Would you like to store an item?\tYes/No");
                            if (Console.ReadLine().ToLower() == "yes")
                            {
                                Console.WriteLine("What Slot would you like to store in?");
                                Console.Write("Slot#:");
                                int sSlot = int.Parse(Console.ReadLine());

                                Console.WriteLine("What item would you like to store?");

                                text.InventoryScript();
                                ship.DisplayInventory();

                                Console.Write("Item:");
                                int iToS = int.Parse(Console.ReadLine());

                                ship.StorageAdd(sSlot - 1, iToS - 1);
                            }
                        }
                        catch (Exception e)
                        {
                            continue;
                        }
                            else
                            {
                                Console.Clear();

                                Console.WriteLine("Would you like to take an item out of storage? Yes/No?");
                                if (Console.ReadLine().ToLower() == "yes")
                                {
                                    text.InventoryScript();
                                    ship.DisplayInventory();
                                    Console.WriteLine("What Slot would you like to store in?");
                                    int iSlot = int.Parse(Console.ReadLine());

                                    Console.WriteLine("What stored item would you like to move to inventory?");

                                    text.StorageScript();
                                    ship.StoredItems();

                                    Console.Write("Item:");
                                    int sToI = int.Parse(Console.ReadLine());
                                    ship.InventoryAdd(iSlot - 1, sToI - 1);

                                }
                                else
                                    ship.Continues();
                            }

                            break;

                        case 3:

                            //Select Destination
                            //Game

                            break;

                        case 4:
                            //Upgrade Station    *Put this in a Do-While loop

                            text.UpgradeScript(ship.InventorySize, ship.StorageSize, ship.MaxFuel);
                            //print what you want to do
                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:

                                    break;

                                case 2:

                                    break;

                                case 3:

                                    break;

                                case 0:

                                    break;
                            }

                            break;

                        case 0:

                            Console.WriteLine("Thanks For Playing!");
                            condition = false;
                            ship.Continues();

                            break;

                        default:

                            break;
                    }

                } 
            while (condition == true);
            
        }
    }
}
