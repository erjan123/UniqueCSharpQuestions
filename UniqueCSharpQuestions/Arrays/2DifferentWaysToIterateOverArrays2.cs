using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UniqueCSharpQuestions.Arrays
{
    public class DifferentWaysToIterateOverArrays2
    {
        // Passing a Action, delegeate Instance, delegate, a Method, Anonymous Method to a List().Foreach() method 

        delegate void MyIteratorDelegate(int number); 

        public static void IterateOverArrays2()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Foreach loop with index using anonymous types 

                foreach (var item in numbers.Select((num, index) => new { num, index }))
                {
                    Console.WriteLine("Index : {0} - Value : {1} ", item.index, item.num);
                }

            #endregion

            Console.WriteLine();
            Console.WriteLine("******************************");

            #region Passing Action to a Foreach()

            Action<int> iteratorAction = new Action<int>(Iterator);
                Console.WriteLine("Passing the an Action to Foreach(): ");
                numbers.ToList().ForEach(iteratorAction);

            #endregion

            #region Passing a method to a Foreach()

                Console.WriteLine();
                Console.WriteLine("Passing the Iterator Method to Foreach(): " );
                numbers.ToList().ForEach(Iterator);

            #endregion

            #region Passing a delegate to Foreach()

                Console.WriteLine();
                Console.WriteLine("Passing the delegate instance to Foreach(): ");
                MyIteratorDelegate myIteratorDelegate = Iterator;
                numbers.ToList().ForEach(num => myIteratorDelegate(num));

            #endregion

            #region Passing directly a delegate with anonymous method to Foreach()

                Console.WriteLine();
                Console.WriteLine("Passing the delegate with anonymous method to Foreach(): ");
                numbers.ToList().ForEach(delegate (int num) { Console.WriteLine(num); });

            #endregion

            #region Passing anonymous methods to Foreach()

                Console.WriteLine();
                Console.WriteLine("Passing an anonymous method to Foreach(): ");
                numbers.ToList().ForEach(num => Console.WriteLine(num));

            #endregion

            Console.Read();
        }

        private static void Iterator(int num)
        {
            Console.WriteLine("Iterotor Method! " + num);
        }
          
    }
}
