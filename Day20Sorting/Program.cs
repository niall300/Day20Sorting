using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task
//Given an array, a, of size n containing distinct elements, sort array  in ascending order
//    using the Bubble Sort algorithm.Once sorted, print the following lines:

//Array is SortedDictionary in numSwaps swaps

//where  numswaps is the number of swaps that took place.

//    FirstElement: firstElement
//where  firstElement is the first element in the sorted array.
//    LastElement : lastElement
//where lastElement is the last element in the sorted array.
namespace Day20Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            //int[] a = { 3, 2,1 };

            //PrintArray(a);
            //Console.ReadLine();

            SortArrayAscending(a);

            //PrintArray(result);
            //Console.ReadLine();


        }
        public static void SortArrayAscending(int[] arr)
        {
           // PrintArray(arr);
            int numswaps = 0;
            int firstElement = 0;
            int lastElement = 0;
            int length = arr.Length;
            //Console.WriteLine("array length is: " + length);
            //Console.ReadLine();


            //create bubblesort 

            
            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < length - i; j++)
                {
                    //if i is bigger than next int then swap them
                   if (arr[j] > arr[j+ 1])
                   {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                        numswaps++;

                    }
                    
                   

                    //if i is smaller than next int do nothing
                    //if i is equal to next int do nothing

                    //if i is bigger than next int then swap themy7

                }



            }

            firstElement = arr[0];
            lastElement = arr[arr.Length - 1];
            Console.WriteLine("First Element: {0}" , firstElement);
            Console.WriteLine("Last Element: {0}" , lastElement);
            //PrintArray(arr);
            Console.WriteLine("Array is sorted in {0} swaps. " , numswaps);
            Console.ReadLine();


           // return arr;
        }
        public static void PrintArray(int[] myArray)
        {
            foreach(var v in myArray)
            {
                Console.Write(v + " " );
            }
        }
    }
}
