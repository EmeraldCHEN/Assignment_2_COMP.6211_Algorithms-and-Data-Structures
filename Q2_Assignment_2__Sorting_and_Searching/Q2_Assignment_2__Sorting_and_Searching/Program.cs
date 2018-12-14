using System;

/* Developer: Yuan Chen (Emerald 27044044)

   This program will display an array and prompt the user to type one number in the array and its occurrence to be found, 

   then display the corresponding index  to the screen. */


namespace Q2_Assignment_2__Sorting_and_Searching
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
            // Prompts for and obtains input from user (assuming all user's inputs are correct)
            Console.Write("\n\nWhat Value you wanted to find in this array: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nWhich Occurance you wanted to find in this array: ");
            int occurance = Convert.ToInt32(Console.ReadLine());

            // Calls the  NumOccuranceSearch method to get the required index 
            int index = NumOccuranceSearch(rndArr, value, occurance);

            // Displays the index of the occurrence of that number to the screen 
            Console.Write("\n\nThe item {0} has occurance {1} at index: {2}",value,occurance,index);

            Console.ReadKey();       
            }
        // Creates the NumOccuranceSearch method using a modified sequential search algorithm to find an occurrence of a certain number in the array 
        public static int NumOccuranceSearch(int[] arr, int value, int occurance)
        {          
            {
                int index = 0; 
                int count = 0;
             
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == value && count != occurance) 
                    {
                        index = i;
                        count++;
                    }                               
                }
                return index;
            }
        }
    }
}
