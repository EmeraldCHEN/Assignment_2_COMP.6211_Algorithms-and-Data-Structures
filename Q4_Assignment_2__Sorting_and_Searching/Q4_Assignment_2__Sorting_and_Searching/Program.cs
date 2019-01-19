using System;
using System.Diagnostics;


/* Developer: Yuan Chen (Emerald)

   This program will implement the standard bubble sort algorithm and another two improved methods to modify the algorithm , 
   
   and then time how long they take to sort the same data. */

namespace Q4_Assignment_2__Sorting_and_Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rndArr = new int[100];

            // Populates the array with 100 random numbers and displays them   
                     
            BubbleSortTest b = new BubbleSortTest();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nOriginal array 1 : ");
            Console.ResetColor();
            Random rnd1 = new Random();
            for (int i = 0; i < 100; i++)
            {
                rndArr[i] = rnd1.Next(0, 100);
                Console.Write(rndArr[i] + " ");
            }          
            b.bubbleSort(rndArr); // Calls the bubbleSort method

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\nOriginal array 2 : ");
            Console.ResetColor();

            // Recreates the original array
            Random rnd2 = new Random();
            for (int i = 0; i < 100; i++)
            {
                rndArr[i] = rnd2.Next(0, 100);
                Console.Write(rndArr[i] + " ");
            }
            b.improvedBubbleSort(rndArr); // Calls the improvedBubbleSort method

            Console.ReadKey();
        }
    }
    // Creates a class called BubbleSortTest
    class BubbleSortTest
    {
        // Creates a method called bubbleSort to implement the standard bubble sort algorithm 
        public void bubbleSort(int[] arr)
        {
            // Time how long  to sort the values in an array 
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int temp = 0;
            for (int count = 0; count < arr.Length; count++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            timer.Stop();
            Console.WriteLine("\n\nSorted array 1 :\n");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }         
            // Outputs the resulting time to the screen to see if any improvement in times has been achieved
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nTime for standard bubble sort : {0}", timer.Elapsed);
            Console.ResetColor();
        }
        // Create a method called improvedBubbleSort to implement 2 improved  bubble sort algorithms 
        public void improvedBubbleSort(int[] arr)
        {          
            // Time how long  to sort the values in an array by improvement 1
            Stopwatch timer = new Stopwatch();
            timer.Start();
            // Modifies the bubble sort algorithm to reduce the number of comparisons
            int temp1 = 0;
            for (int count1 = 0; count1 < arr.Length; count1++)
            {
                for (int sort1 = 0; sort1 < arr.Length - 1 - count1; sort1++)
                {
                    if (arr[sort1] > arr[sort1 + 1])
                    {
                        temp1 = arr[sort1 + 1];
                        arr[sort1 + 1] = arr[sort1];
                        arr[sort1] = temp1;                     
                    }
                }
            }
            timer.Stop();
            Console.WriteLine("\n\nSorted array 2 :\n");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }    
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\nTime for bubble sort improvement one: {0}", timer.Elapsed);
            Console.ResetColor();

            // Recreates the original array
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nOriginal array 3: ");
            Console.ResetColor();
            Random rnd2 = new Random();
            for (int i = 0; i < 100; i++)
            {
                arr[i] = rnd2.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            // Time how long to sort the values in an array by improvement 2
            Stopwatch timerAgain = new Stopwatch();
            timerAgain.Start();

            // Further modification of the algorithm 
            int temp2 = 0;
            for (int count2 = 0; count2 < arr.Length; count2++)
            {
                bool noSwap = true;
                for (int sort2 = 0; sort2 < arr.Length - 1 - count2; sort2++)
                {                  
                    if (arr[sort2] > arr[sort2 + 1])                
                    {
                        temp2 = arr[sort2 + 1];
                        arr[sort2 + 1] = arr[sort2];
                        arr[sort2] = temp2;
                        noSwap = false; // If swaps have been made at the end of each pass,  'noSwap' will be assigned to false
                    }
                }
                if(noSwap)     // If no swap has been made, which means the data must already be in the proper order, 'noSwap' remains true                          
                {
                    break;    //  the algorithm will terminate
                }

                /* P.S. This method only works in the fastest way for sorted arrays partially or completely . 
                        Otherwaise it'll take more time than the previous method. 
                        The reason is that it has to check if any swap has been made at each loop and only sorted part of the array could break out of the whole loop at that point.   */
            }
            timerAgain.Stop();
            Console.WriteLine("\n\nSorted array 3 :\n");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }        
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nTime for bubble sort improvement two : {0}", timerAgain.Elapsed);
            Console.ResetColor();
        }               
    }
}
