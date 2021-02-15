using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("# Reversing the array  #");

            for (int x = arr1.Length - 1; x >= 0; x--)
                Console.WriteLine(arr1[x]);

            Console.WriteLine("\n");


            
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int x = 0; x < arr2.Length; x++)
                sum += arr2[x];
            Console.WriteLine("Sum of all the array elements: {0}", sum);

            Console.WriteLine("\n");

            

            int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrTmp = new int[arr3.Length];

            for (int x = 0; x < arr3.Length; x++)
                arrTmp[x] = arr3[arr3.Length - 1 - x];

            Console.WriteLine("#  Duplicated numbers  #");
            for (int x = 0; x < arrTmp.Length; x++)
                Console.WriteLine(arrTmp[x]);

            Console.WriteLine("\n");


            int[] arr4 = new int[] { 1, 1 ,4 ,5 ,6 ,6 ,7 ,9 ,9 ,9 };
            int max = 0;

            for (int x = 0; x < arr4.Length; x++)
                if (arr4[x] > max)
                    max = arr4[x];

            int[] arrCount = new int[max + 1];

            for (int x = 0; x < arrCount.Length; x++)
                arrCount[x] = 0;

            for (int x = 0; x < arr4.Length; x++)
                arrCount[arr4[x]]++;

            for (int x = 0; x < arrCount.Length; x++)
                if (arrCount[x] != 0)
                    Console.WriteLine("{0} is {1} times", x, arrCount[x]);

            Console.WriteLine("\n");


           

            Console.WriteLine("#  Unique numbers  #");

            for (int x = 0; x < arrCount.Length; x++)
                if (arrCount[x] == 1)
                    Console.WriteLine("{0} is {1} times", x, arrCount[x]);

            Console.WriteLine("\n");
        }
    }
}