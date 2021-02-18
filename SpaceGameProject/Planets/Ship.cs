using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    //Enum For goods 
    public enum Goods {Empty,Earth_Crystal, Heat_Crystal, Water_Crystal, Ice_Crystal, Gas_Crystal }
    //Testing push 4.5  
    //Testing  10

    public class Ship
    {
        //Fields

        public string ShipName { get; set; }
        public int Fuel { get; set; }
        public int MaxFuel { get; set; }

        public int Wallet { get; set; }
        
        public int InventorySize { get; set; }  

        public int StorageSize { get; set; }

        Goods[]? ShipInventory { get; set; }

        Goods[]? ShipStorage { get; set; }
        public Ship()
        {
            ShipName = "S.S Salty";
            Fuel = 100;
            MaxFuel = 100;
            InventorySize = 10;
            StorageSize = 10;

            int i = InventorySize;
            ShipInventory = new Goods[i];
            
            //Adds to the ships Inventory one of each crystal
                 for (int I = 0; I < 5; I++)
                 {
                    ShipInventory[I] = (Goods)I;
                 }

            int s = StorageSize;
            ShipStorage = new Goods[s];
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
               int goods = ShipInventory.Length;
            
               int num = 0;
            //Display The inventory Array 
            //First space is empty and 
            for (int i = 0; i < goods; i++ )
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
            if(value == true)
            {
                InventorySize += 5;
                
            }

            Continues();
            
        }

        public void InventoryAdd(int arrayPosition,int itemIn) 
        {
            //Copys a select item to inventory and deletes it from storage.  arrayPosition is where you want to move the item to in storage
            //itemIn parameter is the item selected from storage  
            
            
            if (this.ShipStorage[itemIn] == Goods.Empty)
            {

                Console.WriteLine("You Havent Selected Anything");
            }
            else if(ShipInventory[arrayPosition] == Goods.Empty)
            {

                ShipInventory[arrayPosition] = ShipStorage[itemIn];

                ShipStorage[itemIn] = Goods.Empty;

                Console.WriteLine("Item Move Succesful");
            }
            else
            {
                Console.WriteLine("There is an Item here. Try SomeWhere else");
            }
            Continues();
           
        }


        public void StoredItems()
        {
            //Print to screen items in the inventrory 
            int goods = ShipStorage.Length;
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
            if(value== true)
            {
                MaxFuel += 100;
                Console.WriteLine($"Your Ships Max ship Capacity is now {MaxFuel} gals.");
            }

            Continues();
        }
        public void PlanetTravel()
        {

            //Grab the distance between planets and subracts Fuel

        }

        public void ChooseDestination()
        {
            //Takes in the destination and return the Days, and Fuel used.
        }

        public void BuyMethod()
        {
            // Adds items to inventory, removes money from wallet

        }

        public void SellMethod()
        {
            // Removes item form inventory, Adds money to wallet.
        }

        


         
        
    }
}
