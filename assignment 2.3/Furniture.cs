/*Zachary Miller
 * 11/15/2017
 * assignment 2.3
 * The purpose of this assignment is to read a character from the user and then determine the price of the selected table
 * Furniture.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2._3
{
    class Furniture
    {
        static void Main(string[] args)
        {
            String input = getInput();
            int price = determinePrice(input);
            string woodType = getWoodType(input);
            displayOutput(price, woodType);
        }

        private static String getInput()
        {
            Console.WriteLine("Your options for wood are pine, oak, or mahogany.");
            Console.Write("Please enter the type of wood you would like. Type p for pine, o for oak, or m for mahogany: ");
            String input = Console.ReadLine();
            return input;
        }

        private static int determinePrice(String input)
        {
            int price;
            if (input.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                price = 100;
            }
            else if (input.Equals("o", StringComparison.OrdinalIgnoreCase))
            {
                price = 225;
            }
            else if (input.Equals("m", StringComparison.OrdinalIgnoreCase))
            {
                price = 310;
            }
            else
                price = 0;
            return price;
        }

        private static string getWoodType(String selected)
        {
            String woodType;
            
            if (selected.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                woodType = "Pine";
            }
            else if (selected.Equals("o", StringComparison.OrdinalIgnoreCase))
            {
                woodType = "Oak";
            }
            else if (selected.Equals("m", StringComparison.OrdinalIgnoreCase))
            {
                woodType = "Mahogany";
            }
            else
                woodType = "nonexistant";

            return woodType;
        }

        private static void displayOutput(int price, String woodType)
        {
            Console.WriteLine("The total price of the [0] table you selected is $[1].", woodType, price);
            Console.ReadLine();
        }
    }
}
