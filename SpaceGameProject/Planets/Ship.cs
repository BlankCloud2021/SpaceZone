using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Planets
{
    //Enum For goods 
    public enum Goods { Empty, Earth_Crystal, Heat_Crystal, Water_Crystal, Ice_Crystal, Gas_Crystal, Paper_Clip }
   
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

            ShipInventory = new Goods[50];

            //Adds to the ships Inventory one of each crystal
            for (int I = 0; I < 5; I++)
            {
                ShipInventory[I] = (Goods)I;
            }
           
            ShipStorage = new Goods[50];
        }

        //Methods

        //Difficulty Methods
        public void Difficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 0:
                    Console.WriteLine("Wimp Mode Engaged");
                    Continues();
                    break;
                case 1:
                    //Hard
                    Fuel = 100;
                    MaxFuel = 100;
                    InventorySize = 10;
                    StorageSize = 10;
                    Wallet = 500;

                    Console.WriteLine("Hard Mode Engaged");
                    Continues();

                    break;

                case 2:
                    // Soul crushing
                    Fuel = 50;
                    MaxFuel = 100;
                    InventorySize = 5;
                    StorageSize = 5;
                    Wallet = 100;

                    Console.WriteLine("Da Real One Has Arrived");
                    Continues();
                    break;

                case 82882:
                    //Admin
                    Fuel = 300;
                    MaxFuel = 300;
                    InventorySize = 50;
                    StorageSize = 50;
                    Wallet = 15000;

                    Console.WriteLine("Welcome Admin");
                    Continues();
                    break;
            }
           
        }
        


        public void Continues()
        {
            Console.WriteLine("Press any Key to Continue");
            Console.ReadKey();

            Console.Clear();
        }

        
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


        
        public String DisplayShip()
        {
            string? text = null;
            text += ShipName;

            return text.ToString();

        }

        
        public void DisplayInventory()
        {
            int goods = InventorySize;

            int num = 0;
            for (int i = 0; i < goods; i++)
            {

                    Console.WriteLine($"({++num})\t{ShipInventory[i]}  \t   ({++num})\t{ShipInventory[++i]} ");

            }
        }

        
        public void UpgradeInventory()
        {
            if(InventorySize < 50)
            {
                bool value = WalletAltSub(300);
                if (value == true)
                {
                    InventorySize += 5;

                }
            }
            else { Console.WriteLine("Max Inventory Reached"); }

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
            if (StorageSize < 50)
            {
                bool value = WalletAltSub(300);
                if (value == true)
                {
                    StorageSize += 5;

                }
            }
            else { Console.WriteLine("Max Storage Reached"); }

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
                    Console.WriteLine("Dude, you just toped of why even bother \n I'll still take your money though.");
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
        public bool PlanetTravel(Planets current, Planets destination)
        {
            bool check = true;
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
                            check = true;

                            break;

                        case 2:
                            if (!(current == Planets.Pluto))
                            {
                               this.destination = Planets.Pluto;
                            }
                            else { Console.WriteLine("You already on Pluto!"); }
                            check = true;

                            break;

                        case 3:
                            if (!(current == Planets.Mercury))
                            {
                                this.destination = Planets.Mercury;
                            }
                            else { Console.WriteLine("You already on Mercury!"); }
                            check = true;

                            break;

                        case 4:
                            if (!(current == Planets.Mars))
                            {
                                this.destination = Planets.Mars;
                            }
                            else { Console.WriteLine("You already on Mars!"); }
                            check = true;

                            break;

                        case 5:
                            if (!(current == Planets.Jupitar))
                            {
                                this.destination = Planets.Jupitar;
                            }
                            else { Console.WriteLine("You already on Jupitar!"); }
                            check = true;

                            break;

                        case 0:

                            Console.WriteLine("Returning to Main Menu");
                            Continues();

                           check = false;
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
            Continues();
            return check;
        }

        public int ChooseDestination(Planets current, Planets destination, int days)
            {

            //Earth
                if (current == Planets.Earth && destination == Planets.Mars)
                {

                    currentLocation = destination;
                    Fuel -= 11;
                    days -= 100;
                    Console.WriteLine(" Welcome to Mars, you consumed 11 Fuel and spent 100 day traveling.");

                }
                else if (current == Planets.Earth && destination == Planets.Mercury)
                {
                    currentLocation = destination;
                    Fuel -= 9;
                    days -= 100;
                    Console.WriteLine(" Welcome to Mercury, you consumed 9 Fuel and spent 100 day traveling.");
                }
                else if (current == Planets.Earth && destination == Planets.Pluto)
                {
                    currentLocation = destination;
                    Fuel -= 25;
                    days -= 200;
                    Console.WriteLine(" Welcome to Pluto, you consumed 25 Fuel and spent 200 days traveling.");
                }
                else if (current == Planets.Earth && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 45;
                    days -= 300;
                    Console.WriteLine(" Welcome to Jupiter, you consumed 45 Fuel and spent 300 days traveling.");
                }
            // Mercury
            
                else if (current == Planets.Mercury && destination == Planets.Earth)
                {
                currentLocation = destination;
                Fuel -= 15;
                days -= 100;
                Console.WriteLine(" Welcome to Earth, you consumed 20 Fuel and spent 100 day traveling.");
                }

                 else if (current == Planets.Mercury && destination == Planets.Mars)
                {
                    currentLocation = destination;
                    Fuel -= 20;
                    days -= 100;
                    Console.WriteLine(" Welcome to Mars, you consumed 20 Fuel and spent 100 day traveling.");
                }

                else if (current == Planets.Mercury && destination == Planets.Pluto)
                {
                    currentLocation = destination;
                    Fuel -= 34;
                    days -= 300;
                    Console.WriteLine(" Welcome to Pulto, you consumed 34 Fuel and spent 300 days traveling.");
                }
                else if (current == Planets.Mercury && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 54;
                    days -= 400;
                    Console.WriteLine(" Welcome to Jupiter, you consumed 54 Fuel and spent 400 days traveling.");
                }
            //Mars

            else if (current == Planets.Mars && destination == Planets.Earth)
            {
                currentLocation = destination;
                Fuel -= 14;
                days -= 200;
                Console.WriteLine(" Welcome to Earth, you consumed 14 Fuel and spent 200 days traveling.");
            }

            else if (current == Planets.Mars && destination == Planets.Mercury)
            {
                currentLocation = destination;
                Fuel -= 14;
                days -= 200;
                Console.WriteLine(" Welcome to Mercury, you consumed 14 Fuel and spent 200 days traveling.");
            }


            else if (current == Planets.Mars && destination == Planets.Pluto)
                {
                    currentLocation = destination;
                    Fuel -= 14;
                    days -= 200;
                    Console.WriteLine(" Welcome to Pulto, you consumed 14 Fuel and spent 200 days traveling.");
                }
                else if (current == Planets.Mars && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 34;
                    days -= 300;
                    Console.WriteLine(" Welcome to Jupiter, you consumed 34 Fuel and spent 300 days traveling.");
                }


                //Pluto
                else if (current == Planets.Pluto && destination == Planets.Jupitar)
                {
                    currentLocation = destination;
                    Fuel -= 25;
                    days -= 200;
                    Console.WriteLine(" Welcome to Jupiter, you consumed  10 Fuel and spent 200 days traveling.");
                }

            else if (current == Planets.Pluto && destination == Planets.Earth)
            {
                currentLocation = destination;
                Fuel -= 55;
                days -= 200;
                Console.WriteLine(" Welcome to Earth, you consumed  10 Fuel and spent 200 days traveling.");
            }

            else if (current == Planets.Pluto && destination == Planets.Mars)
            {
                currentLocation = destination;
                Fuel -= 30;
                days -= 200;
                Console.WriteLine(" Welcome to Mars, you consumed  10 Fuel and spent 200 days traveling.");
            }

            else if (current == Planets.Pluto && destination == Planets.Mercury)
            {
                currentLocation = destination;
                Fuel -= 25;
                days -= 200;
                Console.WriteLine(" Welcome to Mercury, you consumed  10 Fuel and spent 200 days traveling.");
            }

            return days;
        }

        public void BuyMethod(int inventoryPlace, Goods itemBuy, int price)
            {
            // Adds items to inventory, removes money from wallet
            if (this.ShipInventory[inventoryPlace] == Goods.Empty)
            {

                bool value = WalletAltSub(price);
                if (value == true)
                {
                    this.ShipInventory[inventoryPlace] = itemBuy;
                    Console.WriteLine("Item has been added to your inventory");
                }
            }
            else
            {
                Console.WriteLine("Somethings already there!");
            }
            Continues();

        }

        public void SellMethod(int itemsell, Planets planet)
            {

            Goods item = ShipInventory[itemsell];
            if (!(item == Goods.Empty))
            {
                //Radamize a Gift
                switch (item)
                {
                    case Goods.Paper_Clip:
                        string text = ". . . . . . . . ";
                      
                        foreach (char Text in text)
                        {
                            Console.Write(Text);
                            Thread.Sleep(100);
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("\nWhat Made you think Id want a PaperClip?");
                        break;
                    
                    case Goods.Earth_Crystal:

                        switch (planet)
                        {
                            case Planets.Earth:
                                Console.WriteLine("I'll Buy It A High Price $50.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 50;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Pluto:
                                Console.WriteLine("I'll Buy It A High Price $450.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 450;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mercury:
                                Console.WriteLine("I'll Buy It A High Price $100.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 100;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mars:
                                Console.WriteLine("I'll Buy It A High Price $400.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 400;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Jupitar:
                                Console.WriteLine("I'll Buy It A High Price $70.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 70;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                        }


                        break;

                    case Goods.Heat_Crystal:
                        switch (planet)
                        {
                            case Planets.Earth:
                                Console.WriteLine("I'll Buy It A High Price $550.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 550;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Pluto:
                                Console.WriteLine("I'll Buy It A High Price $200.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 200;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mercury:
                                Console.WriteLine("I'll Buy It A High Price $50.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 50;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mars:
                                Console.WriteLine("I'll Buy It A High Price $300.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 300;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Jupitar:
                                Console.WriteLine("I'll Buy It A High Price $0.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 0;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                        }

                        break;


                    case Goods.Ice_Crystal:
                        switch (planet)
                        {
                            case Planets.Earth:
                                Console.WriteLine("I'll Buy It A High Price $300.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 300;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Pluto:
                                Console.WriteLine("I'll Buy It A High Price $200.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 200;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mercury:
                                Console.WriteLine("I'll Buy It A High Price $500.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 500;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mars:
                                Console.WriteLine("I'll Buy It A High Price $150.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 150;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Jupitar:
                                Console.WriteLine("I'll Buy It A High Price $100.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 100;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                        }


                        break;
                    case Goods.Gas_Crystal:
                        switch (planet)
                        {
                            case Planets.Earth:
                                Console.WriteLine("I'll Buy It A High Price $900.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 900;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Pluto:
                                Console.WriteLine("I'll Buy It A High Price $800.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 800;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mercury:
                                Console.WriteLine("I'll Buy It A High Price $0.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 0;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mars:
                                Console.WriteLine("I'll Buy It A High Price $700.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 700;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Jupitar:
                                Console.WriteLine("I'll Buy It A High Price $100.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 100;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                        }

                        break;

                    case Goods.Water_Crystal:
                        switch (planet)
                        {
                            case Planets.Earth:
                                Console.WriteLine("I'll Buy It A High Price $100.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 100;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Pluto:
                                Console.WriteLine("I'll Buy It A High Price $400.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 400;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mercury:
                                Console.WriteLine("I'll Buy It A High Price $300.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 300;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Mars:
                                Console.WriteLine("I'll Buy It A High Price $400.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 400;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;
                            case Planets.Jupitar:
                                Console.WriteLine("I'll Buy It A High Price $150.\n Sound Good? Y/N");
                                if (Console.ReadLine().ToLower() == "y")
                                {
                                    ShipInventory[itemsell] = Goods.Empty;
                                    Wallet += 150;
                                    Console.WriteLine("Heh,Heh Thank Ya Stranger");
                                }
                                else
                                    Console.WriteLine("Very well...");

                                break;

                        }
                        break;
                }

            }
            else { Console.WriteLine("You didnt select anything"); }
            }




    }


}


