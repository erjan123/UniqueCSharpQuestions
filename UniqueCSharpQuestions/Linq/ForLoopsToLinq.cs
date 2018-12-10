using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UniqueCSharpQuestions.Linq
{
    public class ForLoopsToLinq
    {
        public static int[] array1 = { 0, 1, 2, 3, 4 };
        public static int[] array2 = { 0, 1, 2, 3, 4 };

        public static void ConvertForLoopsToLinq()
        {
            ConvertOneForLoopToLinq();

            Console.WriteLine("\r\n");
            Console.Write(string.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine();

            ConvertTwoForLoopsToLinq();

            Console.Write(string.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine();
        }

        static void ConvertOneForLoopToLinq()
        {
            Console.WriteLine("Output with For Loop.");
            for(int i = 0; i < array1.Count(); i++)
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine("\r\nOutput with linq with Lambda.");

            array1.ToList().ForEach(i => Console.Write(array1[i] + " "));
        }

        static void ConvertTwoForLoopsToLinq()
        {
            Console.WriteLine("Output with Two For Loops.");
            for (int i = 0; i < array1.Count(); i++)
            {
                Console.WriteLine();
                Console.WriteLine("First Loop : {0}", array1[i]);

                for (int y = 0; y < array2.Count(); y++)
                {
                    Console.Write(array2[y] + " ");
                }
            }

            Console.WriteLine("\r\n");
            Console.WriteLine("Output with linq and Lambda.\r\n");

            array1.ToList().ForEach(i =>  {
                Console.WriteLine("First Loop : {0}", array1[i]);
                array2.ToList().ForEach(x => Console.Write(array2[x] + " "));
                Console.WriteLine();
            });
        }


    }
}
