using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UniqueCSharpQuestions.Arrays
{
    public class DifferentWaysToIterateOverArrays1
    {
        // How many ways you can iterate over an array?

        public static void IterateOverArrays1()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region 1. For loop

                for(byte i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("For Loop : " + numbers[i]);
                }

            #endregion

            Console.WriteLine("**********************");

            #region 2.Foreach loop

                foreach (var item in numbers)
                {
                    Console.WriteLine("Foreach Loop : {0}", item);
                }

            #endregion

            Console.WriteLine("**********************");

            #region 3. Array.Foreach

                Array.ForEach(numbers, num => Console.WriteLine("Array.Foreach : " + num));

            #endregion

            Console.WriteLine("**********************");

            #region 4. ToList().Foreach

                numbers.ToList().ForEach(num => Console.WriteLine("ToList().Foreach : " + num));

            #endregion

            Console.WriteLine("**********************");

            #region 5. Pointer

            unsafe
            {

                    fixed(int* p1 = numbers)
                    {
                        for (int* p2 = p1; p2 < p1 + numbers.Length; p2++)
                        {
                            Console.WriteLine("From pointer : " + *p2);
                        }
                    }
                }

            #endregion

            Console.WriteLine("**********************");

            #region 6. IEnumerator

            IEnumerator enumerator = numbers.GetEnumerator();
                while (enumerator.MoveNext())
                    Console.WriteLine("IEnumerator : " + enumerator.Current);

            #endregion

            Console.Read();
        }
    }
}
