using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;
using System.Linq.Expressions;

namespace UniqueCSharpQuestions.Classes
{
    public class Person
    {
        public string Name;
        public string LastName;

        public Person() { }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public void DoSomething(int num)
        {
            Console.WriteLine(num);
        }
    }

    public static class CreateAnObjectWithoutNewKeyWord
    {
        // How to create an object instances without the "new" keyword?

        #region 1. Activator.CreateInstance() method 

            public static void ActivatorCreateInstance()
            {
                Person tom = (Person)Activator.CreateInstance(typeof(Person));
                tom.Name = "Tom";
                tom.LastName = "Bronw";
                Console.WriteLine("Activator without input parameters.");
                Console.WriteLine("Name : {0}, LastName : {1} ", tom.Name, tom.LastName);

                Console.WriteLine();

                // With parameters
                Person mike = (Person)Activator.CreateInstance(typeof(Person), "Mike", "Hanks");
                Console.WriteLine("Activator with input parameters.");
                Console.WriteLine("Name : {0} and LastName : {1}", mike.Name, mike.LastName);

            }

        #endregion


    }
}
