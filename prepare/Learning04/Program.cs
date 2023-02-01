using System;
using System.Linq;
using System.Collections.Generic;

namespace ManipulateList
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number;
            Console.WriteLine("Enter a list of numbers, type 0 when finished\n");
            List<double> items = new List<double>();

            string userInput;
            //int list_length;
            double sum;
            double minPosNum;

            // repeatedly ask for input from the user until it's a valid double
            do
            {
                double newItem = 0.0;
                minPosNum = 0.0;
                Console.Write(string.Format("Enter number: "));
                // read from console into userInput
                userInput = Console.ReadLine();
                // check if the user's input is a number
                while (!double.TryParse(userInput, out newItem))
                {
                    Console.WriteLine("That's not a number.");
                    Console.WriteLine("Enter a number");
                    userInput = Console.ReadLine();
                }

                if (newItem > 0)
                {
                    if (newItem < minPosNum)
                    {
                        minPosNum = newItem;
                    }
                }
                // add the new item to the array
                items.Add(newItem);
            } while (userInput != "0");

            // output all the items to the console, separated by commas
            if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
            }
            Console.Write("Your list elements are : \n");
            Console.WriteLine(string.Join("\n ", items.Select(item => item.ToString())));

            //Console.Write($"Number of elements: {list_length}\n");
            Console.Write($"Number of elements: {items.Count}\n");

            sum = items.Sum();
            Console.Write($"Sum of elements: {sum}\n");

            double avg = sum / items.Count;
            Console.Write($"Average of elements: {avg}\n");

            //To find the largest element in the list and its position
            int maxValue = (int)items.Max();
            int maxIndex = items.IndexOf(maxValue);
            //To find the smallest element in the list and its position
            int minValue = (int)items.Min();
            int minIndex = items.IndexOf(minValue);
            Console.WriteLine("Maximum element {0} present at index {1}", maxValue, maxIndex);
            Console.WriteLine("Minimum element {0} present at index {1}", minValue, minIndex);

            //The smallest positive number
            Console.Write($"The smallest positive number is: {minPosNum}\n");

            //Sorting
            items.Sort();
            Console.Write("After Sorting, Your list elements are : \n");
            Console.WriteLine(string.Join("\n ", items.Select(item => item.ToString())));
        }
    }
}
