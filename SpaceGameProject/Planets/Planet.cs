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

        //Create array for the items that a merchant has in stock 
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

       

}

    public class Earth : Planet
    {
        public Earth()
        {
            planetName = "Earth";
            valuble = "Earth Crystal";
            saturatedResource = "";
            Weather = "Clear Skies";
            Wealth = "";
            MerchantName = "Ikora";
            MerchantType = "Reliable";
            Goods[] MerchantInventory = new Goods[] {Goods.Earth_Crystal, Goods.Water_Crystal};

         }

    }

    public class Pluto : Planet
    {
        public Pluto()
        {
            planetName = "Pluto";
            valuble = "Heat Crystal";
            saturatedResource = "Ice Crystal";
            Weather = "Brisk Cold";
            Wealth = "";
            MerchantName = "Zeplin";
            MerchantType = "Modest";
            Goods[] MerchantInventory = new Goods[] {Goods.Ice_Crystal,Goods.Heat_Crystal};

        }
    }

    public class Mercury : Planet
    {
        public Mercury()
        {
            planetName = "Mercury";
            valuble = "Ice Crystal";
            saturatedResource = "Heat Crystal";
            Weather = "Hot";
            Wealth = "";
            MerchantName = "Yzelta";
            MerchantType = "Prideful";
            Goods[] MerchantInventory = new Goods[] {Goods.Ice_Crystal,Goods.Heat_Crystal,Goods.Earth_Crystal};

        }
    }

    public class Mars : Planet
    {
        public Mars()
        {
            planetName = "Mars";
            valuble = "Water Crystal";
            saturatedResource = "Earth Crystal";
            Weather = "Dry";
            Wealth = "";
            MerchantName = "Zephyr";
            MerchantType = "Shady";
            Goods[] MerchantInventory = new Goods[] {Goods.Water_Crystal,Goods.Earth_Crystal,Goods.Ice_Crystal};

        }
    }

    public class Jupiter : Planet
    {
        public Jupiter()
        {
            planetName = "Jupiter";
            valuble = "Earth Crystal";
            saturatedResource = "Gas Crystal";
            Weather = "Windy";
            Wealth = "";
            MerchantName = "Ashton";
            MerchantType = "Scammers";
            Goods[] MerchantInventory = new Goods[] {Goods.Gas_Crystal,Goods.Earth_Crystal };

        }
    }
}
