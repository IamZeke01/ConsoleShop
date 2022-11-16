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
			Console.WriteLine($"\tYour currrent shop balance is ${money}.\n");
			Console.WriteLine("\tShop category 1			 - Press [1].");
			Console.WriteLine("\tShop category 2			 - Press [2].");
			Console.WriteLine("\tShop category 3		  	 - Press [3].");
			Console.WriteLine("\tAdd funds to Shop Balance	 - Press [4].");
			Console.WriteLine("\tExit Application            - Press [0].\n");
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
			Console.WriteLine("\t*********************************************************************\n");
			Console.WriteLine($"\tYour currrent shop balance is ${money}.\n");
			Console.WriteLine("\t************ Category One Products *********************************\n");
			Console.WriteLine("\tProduct 1 ($10)			- to purchase press [1]");
			Console.WriteLine("\tProduct 2 ($5)				- to purchase press [2]");
			Console.WriteLine("\tProduct 3 ($5)				- to purchase press [3]");
			Console.WriteLine("\tProduct 4 ($10)			- to purchase press [4]");
			Console.WriteLine("\tReturn to Shop Front		- Press [5]\n");
			Console.WriteLine("\t********************************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");
			Console.Write("\t");

			switch (int.Parse(Console.ReadLine()))
            {
				case 1:
					money -= 10;
					Console.WriteLine($"\tYou have purchased product 1 for $10 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					money -= 5;
					Console.WriteLine($"\tYou have purchased product 2 for $5 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					money -= 5;
					Console.WriteLine($"\tYou have purchased product 3 for $5 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					money -= 10;
					Console.WriteLine($"\tYou have purchased product 4 for $10 your remaining shop funds is ${money}");
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
			Console.WriteLine("\t************ Category One Products *************\n");
			Console.WriteLine("\tProduct 1 ($10)			- to purchase press [1]");
			Console.WriteLine("\tProduct 2 ($5)				- to purchase press [2]");
			Console.WriteLine("\tProduct 3 ($5)				- to purchase press [3]");
			Console.WriteLine("\tProduct 4 ($10)			- to purchase press [4]");
			Console.WriteLine("\tReturn to Shop Front		- Press [5]\n");
			Console.WriteLine("\t************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");
			Console.Write("\t");

			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					money -= 10;
					Console.WriteLine($"\tYou have purchased product 1 for $10 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					money -= 5;
					Console.WriteLine($"\tYou have purchased product 2 for $5 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					money -= 5;
					Console.WriteLine($"\tYou have purchased product 3 for $5 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					money -= 10;
					Console.WriteLine($"\tYou have purchased product 4 for $10 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 5:
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
			Console.WriteLine("\t************ Category One Products *************\n");
			Console.WriteLine("\tProduct 1 ($10)			- to purchase press [1]");
			Console.WriteLine("\tProduct 2 ($5)				- to purchase press [2]");
			Console.WriteLine("\tProduct 3 ($5)				- to purchase press [3]");
			Console.WriteLine("\tProduct 4 ($10)			- to purchase press [4]");
			Console.WriteLine("\tReturn to Shop Front		- Press [5]\n");
			Console.WriteLine("\t************************************************\n");
			Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓\n");
			Console.Write("\t");

			switch (int.Parse(Console.ReadLine()))
			{
				case 1:
					money -= 10;
					Console.WriteLine($"\tYou have purchased product 1 for $10 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 2:
					money -= 5;
					Console.WriteLine($"\tYou have purchased product 2 for $5 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 3:
					money -= 5;
					Console.WriteLine($"\tYou have purchased product 3 for $5 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 4:
					money -= 10;
					Console.WriteLine($"\tYou have purchased product 4 for $10 your remaining shop funds is ${money}");
					CategoryOne();
					break;
				case 5:
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