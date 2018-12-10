using System;
using System.Reflection;
using System.Linq;
using UniqueCSharpQuestions.Classes;
using arrays1 = UniqueCSharpQuestions.Arrays.DifferentWaysToIterateOverArrays1;
using arrays2 = UniqueCSharpQuestions.Arrays.DifferentWaysToIterateOverArrays2;
using arrays3 = UniqueCSharpQuestions.Arrays.DifferentWaysToIterateOverArrays3;
using classes = UniqueCSharpQuestions.Classes.CreateAnObjectWithoutNewKeyWord;
using linq = UniqueCSharpQuestions.Linq.ForLoopsToLinq;

namespace UniqueCSharpQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            // arrays1.IterateOverArrays1();
            // arrays2.IterateOverArrays2();
            // arrays3.IterateOverArrays3();

            #endregion

            #region Classes

            //classes.ActivatorCreateInstance();
            //classes.CreateInstanceWithCompileLambda();

            #endregion

            #region Linq
            // Converting For Loops to linq with lambda
            linq.ConvertForLoopsToLinq();

            #endregion


            Console.Read();

        }
    }
}
