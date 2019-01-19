using System;

/* Developer: Yuan Chen (Emerald)

   This program will display an array and prompt the user to type one number in the array 

   then display the last occurrence of the searched number to the screen.   */

namespace Q3_Assignment_2__Sorting_and_Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rndArr = new int[50];

            // Populates the array with 50 integer elements between 1 to 100 at random 
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                rndArr[i] = rnd.Next(1, 100);
            }
            // Displays the array contents
            Console.WriteLine("\nOriginal array : \n");
            foreach (int element in rndArr)
            {
                Console.Write(element + " ");
            }
            // Prompts for and obtains input from the user (assuming all user's inputs are correct)
            Console.Write("\n\nWhat Value you wanted to find in this array: ");
            int value = Convert.ToInt32(Console.ReadLine());
          
            int index = LastOccuranceSearch(rndArr, value); // Calls the LastOccuranceSearch method

            // Display details on screen 
            Console.Write("\n\nThe item {0} has last occurane at index: {1}", value, index);
            Console.ReadKey();
        }
        // Creates the LastOccuranceSearch method using linear search algorithm to find the index of the last occurance of the value the user wants to search for 
        public static int LastOccuranceSearch(int[] arr, int value)
        {
            {
                int index = 0;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] == value ) 
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
        }  
    }
}
