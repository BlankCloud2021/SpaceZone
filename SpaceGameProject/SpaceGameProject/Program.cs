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
            Earth ikora = new Earth();
            Pluto zeplin = new Pluto();
            Mercury yzelta = new Mercury();
            Mars zephyr = new Mars();
            Jupiter ashton = new Jupiter();


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
                while(x)
                try
                {
                    text.MainMenu(ship.Fuel, game.daysRemaining, ship.Wallet);
                    Console.WriteLine("What would you like to do?");
                    uInput = int.Parse(Console.ReadLine());
                        x = false;
                }
                catch
                {
                        Console.WriteLine("Enter a valid option.");
                        x = true;
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
                        bool store = true;
                        while (store)
                        {
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
                                    store = false;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Enter a valid option");
                                store = true;
                                continue;
                                
                            }
                        }
                        break;

                    case 3:

                        //Select Destination
                        //Game
                        text.PlanetMenu(ship.Fuel, game.daysRemaining);
                       
                        ship.PlanetTravel(ship.currentLocation,ship.destination);
                       
                        game.daysRemaining = ship.ChooseDestination(ship.currentLocation, ship.destination, game.daysRemaining);
                       
                        switch (ship.destination)
                        {
                            case Planets.Planets.Earth:
                                ikora.Stock();
                                Console.WriteLine(ikora.Merchantwelcome());
                                
                                Console.Write("Choose:");
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        //Buy
                                        bool check = true;
                                        do
                                        {
                                            ship.Continues();

                                            Console.WriteLine("Where do you want to place the item you buy");
                                            ship.DisplayInventory();

                                            ikora.Stock();

                                            Console.Write("Choose:");
                                            int itemPlace = (int.Parse(Console.ReadLine()) - 1);
                                            Goods input5 = Goods.Empty;
                                            int price = 0;


                                            Console.WriteLine("What Item would you like to buy?");

                                            switch (int.Parse(Console.ReadLine()))
                                            {
                                                case 1:
                                                    input = ikora.merchantInventory[0];
                                                    price = 300;
                                                    break;

                                                case 2:
                                                    input = ikora.merchantInventory[1];
                                                    price = 100;
                                                    break;
                                            }
                                            ship.BuyMethod(itemPlace, input5, price);

                                            Console.Write("Do you want to buy anything else? Yes/No:");
                                            if(Console.ReadLine().ToLower() == "no")
                                            {
                                                check = false;
                                            }
                                            ship.Continues();

                                        } while (check);
                                        break;

                                    case 2:
                                        //Sell
                                        ship.Continues();
                                        Console.WriteLine("What do you want to sell");
                                        ship.DisplayInventory();
                                        int input = (int.Parse(Console.ReadLine())-1);

                                        ship.SellMethod(input);
                                        break;

                                    case 0:
                                        //Exit

                                        break;
                                }

                                ship.Continues();
                                break;

                            case Planets.Planets.Pluto:
                                zeplin.Stock();
                                Console.WriteLine(zeplin.Merchantwelcome());

                                Console.Write("Choose:");
                                
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        //Buy
                                        bool check = true;
                                        do
                                        {
                                            ship.Continues();

                                            Console.WriteLine("Where do you want to place the item you buy");
                                            ship.DisplayInventory();

                                            zeplin.Stock();

                                            Console.Write("Choose:");
                                            int itemPlace = (int.Parse(Console.ReadLine()) - 1);
                                            Goods input4 = Goods.Empty;
                                            int price = 0;


                                            Console.WriteLine("What Item would you like to buy?");

                                            switch (int.Parse(Console.ReadLine()))
                                            {
                                                case 1:
                                                    input4 = zeplin.merchantInventory[0];
                                                    price = 300;
                                                    break;

                                                case 2:
                                                    input4 = zeplin.merchantInventory[1];
                                                    price = 100;
                                                    break;
                                            }
                                            ship.BuyMethod(itemPlace, input4, price);

                                            Console.Write("Do you want to buy anything else? Yes/No:");
                                            if (Console.ReadLine().ToLower() == "no")
                                            {
                                                check = false;
                                            }
                                            ship.Continues();

                                        } while (check);
                                        break;

                                    case 2:
                                        //Sell
                                        ship.Continues();
                                        Console.WriteLine("What do you want to sell");
                                        ship.DisplayInventory();
                                        int input = (int.Parse(Console.ReadLine()) - 1);

                                        ship.SellMethod(input);
                                        break;

                                    case 0:
                                        //Exit

                                        break;
                                }

                                ship.Continues();
                                break;

                            case Planets.Planets.Mercury:
                                yzelta.Stock();
                                Console.WriteLine(yzelta.Merchantwelcome());

                                Console.Write("Choose:");
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        //Buy
                                        bool check = true;
                                        do
                                        {
                                            ship.Continues();

                                            Console.WriteLine("Where do you want to place the item you buy");
                                            ship.DisplayInventory();

                                            yzelta.Stock();

                                            Console.Write("Choose:");
                                            int itemPlace = (int.Parse(Console.ReadLine()) - 1);
                                            Goods input3 = Goods.Empty;
                                            int price = 0;


                                            Console.WriteLine("What Item would you like to buy?");

                                            switch (int.Parse(Console.ReadLine()))
                                            {
                                                case 1:
                                                    input3 = yzelta.merchantInventory[0];
                                                    price = 300;
                                                    break;

                                                case 2:
                                                    input3 = yzelta.merchantInventory[1];
                                                    price = 100;
                                                    break;
                                            }
                                            ship.BuyMethod(itemPlace, input3, price);

                                            Console.Write("Do you want to buy anything else? Yes/No:");
                                            if (Console.ReadLine().ToLower() == "no")
                                            {
                                                check = false;
                                            }
                                            ship.Continues();

                                        } while (check);
                                        break;

                                    case 2:
                                        //Sell
                                        ship.Continues();
                                        Console.WriteLine("What do you want to sell");
                                        ship.DisplayInventory();
                                        int input = (int.Parse(Console.ReadLine()) - 1);

                                        ship.SellMethod(input);
                                        break;

                                    case 0:
                                        //Exit

                                        break;
                                }

                                ship.Continues();
                                break;

                            case Planets.Planets.Mars:
                                zephyr.Stock();
                                Console.WriteLine(zephyr.Merchantwelcome());

                                Console.Write("Choose:");
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        //Buy
                                        bool check = true;
                                        do
                                        {
                                            ship.Continues();

                                            Console.WriteLine("Where do you want to place the item you buy");
                                            ship.DisplayInventory();

                                            zephyr.Stock();

                                            Console.Write("Choose:");
                                            int itemPlace = (int.Parse(Console.ReadLine()) - 1);
                                            Goods input1 = Goods.Empty;
                                            int price = 0;


                                            Console.WriteLine("What Item would you like to buy?");

                                            switch (int.Parse(Console.ReadLine()))
                                            {
                                                case 1:
                                                    input1 = zephyr.merchantInventory[0];
                                                    price = 300;
                                                    break;

                                                case 2:
                                                    input1 = zephyr.merchantInventory[1];
                                                    price = 100;
                                                    break;
                                            }
                                            ship.BuyMethod(itemPlace, input1, price);

                                            Console.Write("Do you want to buy anything else? Yes/No:");
                                            if (Console.ReadLine().ToLower() == "no")
                                            {
                                                check = false;
                                            }
                                            ship.Continues();

                                        } while (check);
                                        break;

                                    case 2:
                                        //Sell
                                        ship.Continues();
                                        Console.WriteLine("What do you want to sell");
                                        ship.DisplayInventory();
                                        int input = (int.Parse(Console.ReadLine()) - 1);

                                        ship.SellMethod(input);
                                        break;

                                    case 0:
                                        //Exit
                                        ship.Continues();
                                        break;
                                }

                                ship.Continues();
                                break;

                            case Planets.Planets.Jupitar:
                                ashton.Stock();
                                Console.WriteLine(ashton.Merchantwelcome());

                                Console.Write("Choose:");
                                switch (int.Parse(Console.ReadLine()))
                                {
                                    case 1:
                                        //Buy
                                        bool check = true;
                                        do
                                        {
                                            ship.Continues();

                                            Console.WriteLine("Where do you want to place the item you buy");
                                            ship.DisplayInventory();

                                            ashton.Stock();

                                            Console.Write("Choose:");
                                            int itemPlace = (int.Parse(Console.ReadLine()) - 1);
                                            Goods input2 = Goods.Empty;
                                            int price = 0;


                                            Console.WriteLine("What Item would you like to buy?");

                                            switch (int.Parse(Console.ReadLine()))
                                            {
                                                case 1:
                                                    input2 = ashton.merchantInventory[0];
                                                    price = 300;
                                                    break;

                                                case 2:
                                                    input2 = ashton.merchantInventory[1];
                                                    price = 100;
                                                    break;
                                            }
                                            ship.BuyMethod(itemPlace, input2, price);

                                            Console.Write("Do you want to buy anything else? Yes/No:");
                                            if (Console.ReadLine().ToLower() == "no")
                                            {
                                                check = false;
                                            }
                                            ship.Continues();

                                        } while (check);
                                        break;

                                    case 2:
                                        //Sell
                                        ship.Continues();
                                        Console.WriteLine("What do you want to sell");
                                        ship.DisplayInventory();
                                        int input = (int.Parse(Console.ReadLine()) - 1);

                                        ship.SellMethod(input);
                                        break;

                                    case 0:
                                        //Exit
                                        ship.Continues();
                                        break;
                                }

                                ship.Continues();
                                break;
                        }

                        break;

                    case 4:
                        //Upgrade Station    *Put this in a Do-While loop
                        bool upgradeExit = false;
                        Console.Clear();
                        do
                        {
                            
                            text.UpgradeScript(ship.InventorySize, ship.StorageSize, ship.MaxFuel,ship.Wallet);
                            Console.Write("Upgrade:");
                            try
                            {
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
                            }
                            catch
                            {
                                Console.WriteLine("Enter a valid option");
                                continue;
                            }
                        } while (upgradeExit == false);
                        break;

                    case 0:

                        Console.WriteLine("Thanks For Playing!");
                        condition = false;
                        ship.Continues();

                        break;
                }
                game.CheckDeath(ship.ShipInventory,ship.ShipStorage,ship.destination, game.daysRemaining, ship.Fuel);
                game.WinCondition(ship.ShipInventory, ship.ShipStorage);

                
            } while (condition == true);

        }
    }
}
