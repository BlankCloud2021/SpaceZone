﻿using System;
using System.Collections.Generic;
using System.Threading;
using Planets;

namespace SpaceGameProject
{

    public class Script
    {
        Planet planet = new Planet();

        public void Rules()
        {

        }
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string text = "Welcome to the Space Game! ";
            string text2 = "This Story is set on an apocalyptic planet called Earth in 3021. With only 5,000 days  until the planets\n demise, you are an Elemental Merchant tasked Traveling the known galaxy to man buying and selling\n goods. Your goal is to buy 2 Gas crystals from Jupitar and return to earth to secure the earths survival.\n Be warned certain aspects of the journy will spell your doom!";
            foreach (char Text in text)
            {
                Console.Write(Text);
                Thread.Sleep(100);
            }

            Console.WriteLine();
            Thread.Sleep(2000);

            foreach (char Text in text2)
            {
                Console.Write(Text);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Press any Key to Continue");
            Console.ReadKey();

            Console.Clear();

            string text3 = "Your journey begins enter the name of your Ship";
            foreach (char Text in text3)
            {
                Console.Write(Text);
                Thread.Sleep(50);
            }
            Console.WriteLine();

            Console.Write("Your Ship Name:");
        }



        public void WelcomeShip(string name)
        {
            Console.WriteLine($"Welcome Home! On This day {DateTime.Today} We christen this vessel The {name} to the Galaxy");
        }


        public void MainMenu(Planets.Planets currentPlanet, int fuel = 0, int days = 0, int wallet = 0)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("***************** Main Menu *******************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Fuel Level:{fuel}        Days Remaining:{days}");
            Console.WriteLine();
            Console.WriteLine($"           Current Funds:{wallet:C}            ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"           Current Planet:{currentPlanet}            ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tCheck Inventory    (2)\tStore Inventory");
            Console.WriteLine();
            Console.WriteLine("(3)\tSelect Destination (4)\tUpgrades");
            Console.WriteLine();
            Console.WriteLine("(5)\tFuel Refill        (0)\tQuit");
        }

        public void InventoryScript()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Items in Inventory                       Quantity ");
            Console.WriteLine("--------------------------------------------------");
        }

        public void StorageScript()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Items in Storage                               Quantity");
            Console.WriteLine("-------------------------------------------------------");
        }

        public void UpgradeScript(int maxInventory, int maxStorage, int maxFuel, int wallet)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("************** Upgrade Station ****************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Max Fuel:{maxFuel}           Max Storage:{maxStorage}");
            Console.WriteLine($"Max Inventory:{maxInventory} \t Current Funds:{wallet:C}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tUpgrade Fuel       $300   (2)\tUpgrade Storage  $300 ");
            Console.WriteLine();
            Console.WriteLine("(3)\tUpgrade Inventory  $300   (0)\tQuit ");
            Console.WriteLine();

        }

        public void PlanetMenu(int fuel, int days)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("***************** Plant Menu *******************");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Fuel Level:{fuel}        Days Remaining:{days}");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("(1)\tEarth    (2)\tPluto");
            Console.WriteLine();
            Console.WriteLine("(3)\tMercury  (4)\tMars");
            Console.WriteLine();
            Console.WriteLine("(5)\tJupitar  (0)\tQuit");
        }
        public void AssciartMenu()
        {
            Console.WriteLine("                  .                                            .");
            Console.WriteLine("     *   .                  .              .        .   *          .");
            Console.WriteLine("  .         .                     .       .           .      .        .");
            Console.WriteLine("        o.                   .");
            Console.WriteLine("         .              .                  .           .");
            Console.WriteLine("          0    ");
            Console.WriteLine("                 .          .                 ,                ,    ,");
            Console.WriteLine(" .          \\          .                         .");
            Console.WriteLine("      .      \\   ,");
            Console.WriteLine("   .          o.                 .                   .            .");
            Console.WriteLine("     .         \\                 ,             .                .");
            Console.WriteLine("               #\\##\\#      .                              .        .");
            Console.WriteLine("             #  #O##\\###                .                        .");
            Console.WriteLine("   .        #*#  #\\##\\###                       .                     ,");
            Console.WriteLine("        .   ##*#  #\\##\\##               .                     .");
            Console.WriteLine("      .      ##*#  #o##\\#         .                             ,       .");
            Console.WriteLine("          .     *#  #\\#     .                    .             .          ,");
            Console.WriteLine("                      \\          .                         .");
            Console.WriteLine("____^/\\___^--____/\\____O______________/\\/\\---/\\___________---______________");
            Console.WriteLine("   /\\^   ^  ^    ^                  ^^ ^  '\\ ^          ^       ---");
            Console.WriteLine("         --           -            --  -      -         ---  __       ^");
            Console.WriteLine("   --  __ ___--  ^  ^                         --  __");
        }
      


    }
}
