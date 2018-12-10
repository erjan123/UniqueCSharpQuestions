using System;
using System.Linq.Expressions;
using System.Reflection;

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

    public delegate T ObjectActivator<T>(params object[] args);

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
                Console.WriteLine();
            }

        #endregion

        #region 2. Compile Lambda Expressions

        public static void CreateInstanceWithCompileLambda()
        {
            ConstructorInfo[] ctor = typeof(Person).GetConstructors();
            ObjectActivator<Person> createdActivator = GetActivator<Person>(ctor[1]);

            Console.WriteLine("*******************************");          
            Person instance = createdActivator("Bill", "Gates");
            Console.WriteLine("From Compile Lambda Expression:");
            Console.WriteLine("Name: {0} Last Name: {1} ", instance.Name, instance.LastName);
        }

        public static ObjectActivator<T> GetActivator<T>(ConstructorInfo ctor)
        {
            Type type = ctor.DeclaringType;
            ParameterInfo[] paramsInfo = ctor.GetParameters();

            //create a single param of type object[]
            ParameterExpression param =
                Expression.Parameter(typeof(object[]), "args");

            Expression[] argsExp =
                new Expression[paramsInfo.Length];

            //pick each arg from the params array 
            //and create a typed expression of them
            for (int i = 0; i < paramsInfo.Length; i++)
            {
                Expression index = Expression.Constant(i);
                Type paramType = paramsInfo[i].ParameterType;

                Expression paramAccessorExp =
                    Expression.ArrayIndex(param, index);

                Expression paramCastExp =
                    Expression.Convert(paramAccessorExp, paramType);

                argsExp[i] = paramCastExp;
            }

            //make a NewExpression that calls the
            //ctor with the args we just created
            NewExpression newExp = Expression.New(ctor, argsExp);

            //create a lambda with the New
            //Expression as body and our param object[] as arg
            LambdaExpression lambda =
                Expression.Lambda(typeof(ObjectActivator<T>), newExp, param);

            //compile it
            ObjectActivator<T> compiled = (ObjectActivator<T>)lambda.Compile();
            return compiled;
        }

        #endregion
    }
}
