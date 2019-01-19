using System;

/* Developer: Yuan Chen (Emerald)

   This program has the job of displaying the n largest elements in the array  to the screen
   
   'n' comes from the user's input   */

namespace Q1_Assignment_2__Sorting_and_Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rndArr = new int[50];
            // Populates the array with 50 integer elements between 1 to 100 at random 
            Random rnd = new Random();
            for(int i = 0; i<50; i++)
            {
                rndArr[i] = rnd.Next(1,100);
            }
            // Displays the array contents
            Console.WriteLine("\nOriginal array : \n");
            foreach(int element in rndArr)
            {
                Console.Write(element + " ");
            }
            // Prompts for and obtains input from the user
            Console.Write("\n\nHow many maximum values you wanted to find in this array: ");
            int max = Convert.ToInt32(Console.ReadLine());
                       
            Console.Write("\n\n{0} maximum values found are : ",max);

            int[] maxArr = new int[max];
            for (int i = 0; i < max; i++)
            {
                maxArr[i] = findMaximum(rndArr);
            }
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            foreach(int value in maxArr)
            {
                Console.Write(value + " "); // Displays n largest numbers on screen
            }
            Console.ResetColor();
            Console.ReadKey();
        }
        // Creates the findMaximum method using Linear / Sequential Search algorithm to find the  largest element in the array 
        public static int findMaximum(int[] arr)
        {         
            int maxmum = arr[0];
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if(maxmum < arr[i])
                {
                    maxmum = arr[i];
                    maxIndex = i;
                }
            }
            arr[maxIndex] = 0; 
            return maxmum;     // Returns the largest number of the array  
        }
    }
}
