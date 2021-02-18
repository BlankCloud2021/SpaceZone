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
                text.MainMenu(ship.Fuel, game.daysRemaining, ship.Wallet);
                Console.WriteLine("What would you like to do?");
                int uInput = int.Parse(Console.ReadLine());

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

                            ship.StorageAdd(sSlot-1, iToS-1);

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
                        bool upgradeExit = false;
                        Console.Clear();
                        do
                        {
                            text.UpgradeScript(ship.InventorySize, ship.StorageSize, ship.MaxFuel,ship.Wallet);
                            Console.Write("Upgrade:");

                            switch (int.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    //Fuel
                                    ship.Upgradefuel();
                                    break;

                                case 2:
                                    //Storage
                                    ship.UpgradeStorage();
                                    break;

                                case 3:
                                    //Inventory
                                    ship.UpgradeInventory();
                                    break;

                                case 0:
                                    //Exit Upgrage Menu
                                    Console.WriteLine("Come back any time.");
                                    ship.Continues();
                                    upgradeExit = true;
                                    
                                    break;

                            }
                        } while (upgradeExit == false);
                        break;

                    case 0:

                        Console.WriteLine("Thanks For Playing!");
                        condition = false;
                        ship.Continues();

                        break;
                }
                
            } while (condition == true);

        }
    }
}
