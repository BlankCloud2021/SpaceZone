using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    //Enum For goods 
    public enum Goods { Empty, Earth_Crystal, Heat_Crystal, Water_Crystal, Ice_Crystal, Gas_Crystal }
    //Testing push 4.5  
    //Testing  10
    //test frank
    //testing single push
    public class Ship
    {
        //Fields

        public string ShipName { get; set; }
        public int Fuel { get; set; }
        public int MaxFuel { get; set; }

        public int Wallet { get; set; }

        public int InventorySize { get; set; }

        public int StorageSize { get; set; }

        public Planets currentLocation { get; set; }

        public Planets destination { get; set; }
       public Goods[]? ShipInventory { get; set; }

        public Goods[]? ShipStorage { get; set; }
        public Ship()
        {
            ShipName = "S.S Salty";
            Fuel = 100;
            MaxFuel = 100;
            InventorySize = 10;
            StorageSize = 10;
            Wallet = 1000;
            currentLocation = Planets.Earth;

            //int i = InventorySize;
            ShipInventory = new Goods[50];

            //Adds to the ships Inventory one of each crystal
            for (int I = 0; I < 5; I++)
            {
                ShipInventory[I] = (Goods)I;
            }

            // int s = StorageSize;
            ShipStorage = new Goods[50];
        }

        //Methods

        //Continues and clears the screen
        public void Continues()
        {
            Console.WriteLine("Press any Key to Continue");
            Console.ReadKey();

            Console.Clear();
        }

        // Checks to see if enough money is in wallet to make a purchase
        public bool WalletAltSub(int cost)
        {


            if (Wallet >= cost)
            {
                Wallet -= cost;
                Console.WriteLine("Thank you for you purshase");

                return true;
            }
            else
            {
                Console.WriteLine("Insufficent Funds!");
                return false;
            }


        }


        //Return the ships name 
        public String DisplayShip()
        {
            string? text = null;
            text += ShipName;

            return text.ToString();

        }

        //Prints to screen the current inventory. --note Fix first item in array being Empty 
        public void DisplayInventory()
        {
            int goods = InventorySize;

            int num = 0;
            //Display The inventory Array 
            //First space is empty and 
            for (int i = 0; i < goods; i++)
            {

                Console.Write($"({++num})\t{ShipInventory[i]} ");
                Console.WriteLine($"({++num})\t{ShipInventory[++i]} ");

            }
        }

        //Increases the Max Numbers you can store in you inventory
        public void UpgradeInventory()
        {
            // Increase the max array of the inventroy by 5 each time called then subtracts the cost of the upgrade from the wallet 

            bool value = WalletAltSub(300);
            if (value == true)
            {
                InventorySize += 5;

            }

            Continues();

        }

        public void InventoryAdd(int arrayPosition, int itemIn)
        {
            //Copys a select item to inventory and deletes it from storage.  arrayPosition is where you want to move the item to in Inventory
            //itemIn parameter is the item selected from storage  

            if (arrayPosition < InventorySize)
            {
                if (this.ShipStorage[itemIn] == Goods.Empty)
                {

                    Console.WriteLine("You Havent Selected Anything");
                }
                else if (ShipInventory[arrayPosition] == Goods.Empty)
                {

                    ShipInventory[arrayPosition] = ShipStorage[itemIn];

                    ShipStorage[itemIn] = Goods.Empty;

                    Console.WriteLine("Item Move Succesful");
                }
                else
                {
                    Console.WriteLine("There is an Item here. Try SomeWhere else");
                }
            }
            else
            {
                Console.WriteLine("Input out of Range");
            }
            Continues();

        }


        public void StoredItems()
        {
            //Print to screen items in the inventrory 
            int goods = StorageSize;
            int num = 0;

            //Display The inventoru  Array 
            //First space is empty and 
            for (int i = 0; i < goods; i++)
            {

                Console.Write($"({++num})\t{ShipStorage[i]} ");
                Console.WriteLine($"({++num})\t{ShipStorage[++i]} ");

            }

        }

        public void StorageAdd(int arrayPosition, int itemIn)
        {
            // Copys item to storage and deletes it from inventory.
            if (arrayPosition < StorageSize)
            {


                if (this.ShipInventory[itemIn] == Goods.Empty)
                {

                    Console.WriteLine("You Havent Selected Anything");
                }
                else if (ShipStorage[arrayPosition] == Goods.Empty)
                {

                    ShipStorage[arrayPosition] = ShipInventory[itemIn];

                    ShipInventory[itemIn] = Goods.Empty;

                }
                else
                {
                    Console.WriteLine("There is an Item here. Try SomeWhere else");
                }
            }
            else
            {
                Console.WriteLine("Input out of Range");
            }
            Continues();

        }
        public void UpgradeStorage()
        {
            // Increase the max array of the inventroy by 5 each time called then subtracts the cost of the upgrade from the wallet 

            bool value = WalletAltSub(300);
            if (value == true)
            {
                StorageSize += 5;

            }

            Continues();

        }

        public string DisplayRemainingFuel()
        {
            // Displays the current fuel Must be in a console.write line 
            return Fuel.ToString();
        }

        public void RefillFuel()
        {
            //Add 100 Fuel to Tank Then takes money from the wallet. If the fuel is less the MaxFuel then fuel is increased by 100
            // if less then 100 fuel is needed to reach max when called fuel is set to Maxfuel
            bool value = WalletAltSub(100);
            if (value == true)
            {

                if (Fuel < MaxFuel && Fuel >= (MaxFuel - 100))
                {
                    Fuel = MaxFuel;

                }
                else if (Fuel == MaxFuel)
                {
                    Console.WriteLine("Dude, you just toped of why even bother");
                }
            }
            Continues();
        }


        public void Upgradefuel()
        {
            //Upgrades max fuel Statment setting fuel to increments of 100

            bool value = WalletAltSub(300);
            if (value == true)
            {
                MaxFuel += 100;
                Console.WriteLine($"Your Ships Max ship Capacity is now {MaxFuel} gals.");
            }

            Continues();
        }
        public void PlanetTravel(Planets current, Planets destination)
        {
           
            // menu for ship travel 
            Console.WriteLine("Where Do you Wnat to Go?");
            Console.WriteLine();

            Console.Write("Destination:");
            bool test = true;
            do
            {

                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {

                        case 1:
                            if (!(current == Planets.Earth))
                            {
                               this.destination  = Planets.Earth;
                            }
                            else { Console.WriteLine("You already on earth!"); }
                            break;

                        case 2:
                            if (!(current == Planets.Pluto))
                            {
                               this.destination = Planets.Pluto;
                            }
                            else { Console.WriteLine("You already on Pluto!"); }

                            break;

                        case 3:
                            if (!(current == Planets.Mercury))
                            {
                                this.destination = Planets.Mercury;
                            }
                            else { Console.WriteLine("You already on Mercury!"); }

                            break;

                        case 4:
                            if (!(current == Planets.Mars))
                            {
                                this.destination = Planets.Mars;
                            }
                            else { Console.WriteLine("You already on Mars!"); }

                            break;

                        case 5:
                            if (!(current == Planets.Jupitar))
                            {
                                this.destination = Planets.Jupitar;
                            }
                            else { Console.WriteLine("You already on Jupitar!"); }

                            break;

                        case 0:

                            Console.WriteLine("Returning to Main Menu");
                            Continues();

                            break;
    
                    }
                    test = false;
                }
                catch
                {
                    Console.WriteLine("Enter a valid option.");
                    continue;
                }

            } while (test);

        }

            public int ChooseDestination(Planets current, Planets destination, int days)//input 2 planets, Change the math for cases
            {
                //Takes in the destination and return the Days, and Fuel used.
                // Set current location to destination
                // subract fuel based on distance between 
                //Sub days traveled

            //Earth
                if (current == Planets.Earth && destination == Planets.Mars)
                {

                    currentLocation = destination;
                    Fuel -= 11;
                    days -= 100;
                    Console.WriteLine(" Welcome to Mars, you consumed 11 Fuel and spent 1 day traveling.");

                }
                else if (current == Planets.Earth && destination == Planets.Mercury)
                {
                    currentLocation = destination;
                    Fuel -= 9;
                    days -= 100;
                    Console.WriteLine(" Welcome to Mercury, you consumed 9 Fuel and spent 1 day traveling.");
                }
                else if (current == Planets.Earth && destination == Planets.Pluto)
                {
                    currentLocation = destination;
                    Fuel -= 25;
                    days -= 200;
                    Console.WriteLine(" Welcome to Pluto, you consumed 25 Fuel and spent 2 days traveling.");
                }
                else if (current == Planets.Earth && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 45;
                    days -= 300;
                    Console.WriteLine(" Welcome to Jupiter, you consumed 45 Fuel and spent 3 days traveling.");
                }
            // Mercury
            
                else if (current == Planets.Mercury && destination == Planets.Earth)
                {
                currentLocation = destination;
                Fuel -= 20;
                days -= 100;
                Console.WriteLine(" Welcome to Earth, you consumed 20 Fuel and spent 1 day traveling.");
                }

                 else if (current == Planets.Mercury && destination == Planets.Mars)
                {
                    currentLocation = destination;
                    Fuel -= 20;
                    days -= 100;
                    Console.WriteLine(" Welcome to Mars, you consumed 20 Fuel and spent 1 day traveling.");
                }

                else if (current == Planets.Mercury && destination == Planets.Pluto)
                {
                    currentLocation = destination;
                    Fuel -= 34;
                    days -= 300;
                    Console.WriteLine(" Welcome to Pulto, you consumed 34 Fuel and spent 3 days traveling.");
                }
                else if (current == Planets.Mercury && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 54;
                    days -= 400;
                    Console.WriteLine(" Welcome to Jupiter, you consumed 54 Fuel and spent 4 days traveling.");
                }
            //Mars

            else if (current == Planets.Mars && destination == Planets.Earth)
            {
                currentLocation = destination;
                Fuel -= 14;
                days -= 200;
                Console.WriteLine(" Welcome to Pulto, you consumed 14 Fuel and spent 2 days traveling.");
            }

            else if (current == Planets.Mars && destination == Planets.Mercury)
            {
                currentLocation = destination;
                Fuel -= 14;
                days -= 200;
                Console.WriteLine(" Welcome to Pulto, you consumed 14 Fuel and spent 2 days traveling.");
            }


            else if (current == Planets.Mars && destination == Planets.Pluto)
                {
                    currentLocation = destination;
                    Fuel -= 14;
                    days -= 200;
                    Console.WriteLine(" Welcome to Pulto, you consumed 14 Fuel and spent 2 days traveling.");
                }
                else if (current == Planets.Mars && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 34;
                    days -= 300;
                    Console.WriteLine(" Welcome to Jupiter, you consumed 34 Fuel and spent 3 days traveling.");
                }


                //Pluto
                else if (current == Planets.Pluto && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 10;
                    days -= 200;
                    Console.WriteLine(" Welcome to Jupiter, you consumed  10 Fuel and spent 20 days traveling.");
                }

            else if (current == Planets.Pluto && destination == Planets.Earth)
            {
                currentLocation = destination;
                Fuel -= 10;
                days -= 200;
                Console.WriteLine(" Welcome to Jupiter, you consumed  10 Fuel and spent 20 days traveling.");
            }

            else if (current == Planets.Pluto && destination == Planets.Mars)
            {
                currentLocation = destination;
                Fuel -= 10;
                days -= 200;
                Console.WriteLine(" Welcome to Jupiter, you consumed  10 Fuel and spent 20 days traveling.");
            }

            else if (current == Planets.Pluto && destination == Planets.Mercury)
            {
                currentLocation = destination;
                Fuel -= 10;
                days -= 200;
                Console.WriteLine(" Welcome to Jupiter, you consumed  10 Fuel and spent 20 days traveling.");
            }

            return days;
        }

            public void BuyMethod(int inventoryPlace, Goods itemBuy, int price)
            {
            // Adds items to inventory, removes money from wallet
            bool value = WalletAltSub(price);
            if (value == true)
            {
                this.ShipInventory[inventoryPlace] = itemBuy;
                Console.WriteLine("Item has been added to your inventory");
            }

            Continues();

        }

            public void SellMethod(int itemsell, int price = 0 )
            {
            // Removes item form inventory, Adds money to wallet.

            Goods item = ShipInventory[itemsell];
            if (!(item == Goods.Empty))
            {

                switch (item)
                {
                    case Goods.Earth_Crystal:
                        ShipInventory[itemsell] = Goods.Empty;
                        Wallet += 100;

                        break;

                    case Goods.Heat_Crystal:
                        ShipInventory[itemsell] = Goods.Empty;
                        Wallet += 100;

                        break;


                    case Goods.Ice_Crystal:
                        ShipInventory[itemsell] = Goods.Empty;
                        Wallet += 100;

                        break;
                    case Goods.Gas_Crystal:
                        ShipInventory[itemsell] = Goods.Empty;
                        Wallet += 100;

                        break;

                }
            }
            else { Console.WriteLine("You didnt select anything"); }
            }




    }


}


