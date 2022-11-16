using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
		// Global Class Variables
		public static float money = 100;
		public static string username;

		public static void ShopFront()
		{
			Console.WriteLine("*******************************************************\n");
			Console.WriteLine("\tWelcome to Zeke's Media House\n");
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
			Console.WriteLine("******************************************\n");
			Console.WriteLine("\tWhat is your name?\n");
			Console.WriteLine("******************************************\n");
			username = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("*******************************************************\n");
			Console.WriteLine("\tWelcome, " + username + "\n");
			ShopFront();
			Console.ReadKey();
		}

		public static void AddFunds()
        {
			Console.WriteLine("\tPress any button to continue.");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("\tHow much money would you like to add? (without $) ↓↓↓↓");
			money = int.Parse(Console.ReadLine()) + money;
			Console.WriteLine($"\tShop Funds available is now {money}");
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
					money -= 24;
					Console.WriteLine($"\tYou have purchased J Cole | 2014 Forest Hills Drive Album for $24 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					money -= 28;
					Console.WriteLine($"\tYou have purchased Doja Cat | Planet Her Album for $28 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					money -= 17;
					Console.WriteLine($"\tYou have purchased Halsey | Manic Album for $17 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					money -= 22;
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
					money -= 16;
					Console.WriteLine($"\tYou have purchased SAW for $16 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					money -= 24;
					Console.WriteLine($"\tYou have purchased Black Panther for $24 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					money -= 28;
					Console.WriteLine($"\tYou have purchased Smile for $28 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					money -= 18;
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
					money -= 20;
					Console.WriteLine($"\tYou have purchased Counter-Strike Global-Offensiv for $20 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					money -= 27;
					Console.WriteLine($"\tYou have purchased Call Of Duty 4 for $27 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					money -= 31;
					Console.WriteLine($"\tYou have purchased Wii Sports for $31 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					money -= 29;
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
	}
}