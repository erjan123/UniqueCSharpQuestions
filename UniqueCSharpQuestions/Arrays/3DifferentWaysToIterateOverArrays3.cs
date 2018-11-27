using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

// Creating Foreach extension methods to iterate over an array
namespace UniqueCSharpQuestions.Arrays
{
    public static class DifferentWaysToIterateOverArrays3
    {
        public static void ForEach(this int[] source, Action<int> action)
        {
            for (int i = 0; i < source.Length; i++)
                    action(source[i]);
        }

        public static void ForEach<T>(this T[] source, Action<T> action)
        {
            for (int i = 0; i < source.Length; i++)
                    action(source[i]);
        }

        public static void IterateOverArrays3()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] strNumbers = new string[]
            {
                "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
            };

            #region Foreach extension method for int[] (int arrays)

                Console.WriteLine();
                Console.WriteLine("Foreach extension method for int[]");
                numbers.ForEach(num => Console.WriteLine(num));

            #endregion

            #region Foreach  generic extension method 

                Console.WriteLine();
                Console.WriteLine("Foreach generic extension method");
                strNumbers.ForEach(num => Console.WriteLine(num));

            #endregion

            Console.Read();
        }
    }
}
