using System;

namespace Planets
{
    public class Planet
    {
        
        //Feilds
        public string planetName { get; set; } 

        public string valuble{ get; set; }
        public string saturatedResource { get; set; }
        public string Weather { get; set; }
        public string Wealth { get; set; }
        public string MerchantName { get; set; }
        public string MerchantType{ get; set; }
        public Goods[] MerchantInventory { get; set; }

    //Methods 
        
        
        //Print to the screen Merchants Inventory 
        public void Stock()
        {
            // Displays to the screen the inventory ad prices for merchant  
            int goods = MerchantInventory.Length;

            int num = 0;
            //Display The inventory Array 
            
            for (int i = 0; i < goods; i++)
            {

                Console.Write($"({++num})\t{MerchantInventory[i]} ");
                Console.WriteLine($"({++num})\t{MerchantInventory[++i]} ");

            }
        }

        // Returns welcome message for the planet.
        public string Merchantwelcome()
        {
            return $" Welocme to the Planet {planetName}. I the {MerchantType} {MerchantName}" +
                $" at your service. What you buying or are ya here to sell?\n" +
            "-------------------------------------------------------\n" +
            $" (1)\tBuy          (2)\tSell      (0)\tBack \n " +
            "-------------------------------------------------------";
        }

        //Create array for the items that a merchant has in stock 

}

    public class Earth : Planet
    {
        public Earth()
        {
            planetName = "";
            valuble = "";
            saturatedResource = "";
            Weather = "";
            Wealth = "";
            MerchantName = "";
            MerchantType = "";
            Goods[] MerchantInventory = new Goods[] { };

         }

    }

    public class Pluto : Planet
    {
        public Pluto()
        {
            planetName = "";
            valuble = "";
            saturatedResource = "";
            Weather = "";
            Wealth = "";
            MerchantName = "";
            MerchantType = "";
            Goods[] MerchantInventory = new Goods[] { };

        }
    }

    public class Mercury : Planet
    {
        public Mercury()
        {
            planetName = "";
            valuble = "";
            saturatedResource = "";
            Weather = "";
            Wealth = "";
            MerchantName = "";
            MerchantType = "";
            Goods[] MerchantInventory = new Goods[] { };

        }
    }

    public class Mars : Planet
    {
        public Mars()
        {
            planetName = "";
            valuble = "";
            saturatedResource = "";
            Weather = "";
            Wealth = "";
            MerchantName = "";
            MerchantType = "";
            Goods[] MerchantInventory = new Goods[] { };

        }
    }

    public class Jupiter : Planet
    {
        public Jupiter()
        {
            planetName = "";
            valuble = "";
            saturatedResource = "";
            Weather = "";
            Wealth = "";
            MerchantName = "";
            MerchantType = "";
            Goods[] MerchantInventory = new Goods[] { };

        }
    }
}
