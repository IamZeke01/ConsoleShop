﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
		// Global Class Variables
		public static float money;
		public static string username;
		public static float[] items = { 24, 28, 17, 22, 16, 24, 28, 18, 20, 27, 31, 29 };
		public static float calc;

		public static void ShopFront()
		{
			Console.WriteLine("*******************************************************\n");
			Console.WriteLine("\tWelcome to Zeke's Media House, " + username + "\n");
			Console.WriteLine("*******************************************************\n");
			Console.WriteLine($"\tYour currrent shop balance is ${money}\n");
			Console.WriteLine("\tMusic				- Press [1]");
			Console.WriteLine("\tMovies				- Press [2]");
			Console.WriteLine("\tVideo Games			- Press [3]");
			Console.WriteLine("\tAdd funds to Shop Balance	- Press [4]");
			Console.WriteLine("\tExit Application		- Press [0]\n");
			Console.WriteLine("*******************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");
			Console.Write("\t");

			switch (Console.ReadLine())
            {
				case "1":
					CategoryOne();
					break;
				case "2":
					CategoryTwo();
					break;
				case "3":
					CategoryThree();
					break;
				case "4":
					AddFunds();
					break;
				case "5":
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Please enter a valid option!");
					ShopFront();
					break;

            }
		}
		public static void Main()
		{
			money = 100;
			Console.WriteLine("******************************************\n");
			Console.WriteLine("\tWhat is your name?\n");
			Console.WriteLine("******************************************\n");
			username = Console.ReadLine();
			Console.Clear();
			ShopFront();
			Console.ReadKey();
		}

		public static void AddFunds()
        {
			Console.WriteLine("\tPress any button to continue.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("*****************************************************************\n");
			Console.WriteLine("\t↓↓↓↓ How much money would you like to add? (without $) ↓↓↓↓\n");
			Console.WriteLine("*****************************************************************\n");
			money = int.Parse(Console.ReadLine()) + money;
			Console.WriteLine($"\tShop Funds available is now ${money}");
			Console.WriteLine("\tThank you for topping up at Zeke's Media House, Please comeback anytime\n");
			Console.WriteLine("*****************************************************************\n");
			Console.WriteLine("\tPress any button to go back to the menu.");
			Console.ReadKey();
			Console.Clear();
			ShopFront();
		}

		public static void CategoryOne()
        {
			Console.WriteLine("\tPress any button to continue.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("**************************************************************************************\n");
			Console.WriteLine($"\tYour currrent shop balance is ${money}.\n");
			Console.WriteLine("************ Music Products **************************************************\n");
			Console.WriteLine("\tJ Cole | 2014 Forest Hills Drive Album ($24)	- to purchase press [1]");
			Console.WriteLine("\tDoja Cat | Planet Her Album ($28)		- to purchase press [2]");
			Console.WriteLine("\tHalsey | Manic Album ($17)			- to purchase press [3]");
			Console.WriteLine("\tBrent Faiyaz | Fuck the World Album ($22)	- to purchase press [4]");
			Console.WriteLine("\tReturn to Shop Front				- Press [5]\n");
			Console.WriteLine("*************************************************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");
			Console.Write("\t");

			switch (int.Parse(Console.ReadLine()))
            {
				case 1:
					calc = items[0];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased J Cole | 2014 Forest Hills Drive Album for $24 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					calc = items[1];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Doja Cat | Planet Her Album for $28 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					calc = items[2];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Halsey | Manic Album for $17 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					calc = items[3];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Brent Faiyaz | Fuck the World Album for $22 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 5:
					Console.Clear();
					ShopFront();
					break;
				default:
					Console.WriteLine("Please eneter a valid option!");
					CategoryOne();
					break;
			}
		}

		public static void CategoryTwo()
		{
			Console.WriteLine("\tPress any button to continue.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("******************************************************************\n");
			Console.WriteLine($"\tYour currrent shop balance is ${money}.\n");
			Console.WriteLine("************ Movie Products **************************************\n");
			Console.WriteLine("\tSAW ($16)			- to purchase press [1]");
			Console.WriteLine("\tBlack Panther ($24)		- to purchase press [2]");
			Console.WriteLine("\tSmile ($28)			- to purchase press [3]");
			Console.WriteLine("\tScream ($18)			- to purchase press [4]");
			Console.WriteLine("\tReturn to Shop Front		- Press [5]\n");
			Console.WriteLine("******************************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");
			Console.Write("\t");

			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					calc = items[4];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased SAW for $16 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					calc = items[5];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Black Panther for $24 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					calc = items[6];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Smile for $28 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					calc = items[7];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Scream for $18 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 5:
					Console.Clear();
					ShopFront();
					break;
				default:
					Console.WriteLine("Please eneter a valid option!");
					CategoryOne();
					break;
			}
		}

		public static void CategoryThree()
		{
			Console.WriteLine("\tPress any button to continue.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("*********************************************************************************\n");
			Console.WriteLine($"\tYour currrent shop balance is ${money}.\n");
			Console.WriteLine("************ Game Products ******************************************************\n");
			Console.WriteLine("\tCounter-Strike Global-Offensive ($20)		- to purchase press [1]");
			Console.WriteLine("\tCall Of Duty 4 ($27)				- to purchase press [2]");
			Console.WriteLine("\tWii Sports ($31)				- to purchase press [3]");
			Console.WriteLine("\tDiablo III ($29)				- to purchase press [4]");
			Console.WriteLine("\tReturn to Shop Front				- Press [5]\n");
			Console.WriteLine("*********************************************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓\n");
			Console.Write("\t");

			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					calc = items[8];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Counter-Strike Global-Offensiv for $20 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					calc = items[9];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Call Of Duty 4 for $27 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					calc = items[10];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Wii Sports for $31 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:

					calc = items[11];
					MoneyCheck();
					Console.WriteLine($"\tYou have purchased Diablo III for $29 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 5:
					Console.Clear();
					ShopFront();
					break;
				default:
					Console.WriteLine("Please eneter a valid option!");
					CategoryOne();
					break;
			}
		}

		public static void MoneyCheck()
        {
			if (money < calc)
			{
				Console.WriteLine("You don't have enough money to buy this item, please top up some more money before buying this item");
				Console.WriteLine("\tPress any button to go to the menu");
				Console.Clear();
				ShopFront();
			}
			else
            {
				money = money - calc;
            }
		}
	}
}