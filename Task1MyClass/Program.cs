using System;

namespace Task1MyClass
{
    class Program
    {
        static void Main(string[] args)
        {   
            Test test =  MyClass<Test>.FactoryMethod();
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }

    class MyClass<T> where T : new()
    {
        
        public static T FactoryMethod()
        {
            return new T();
        }

    }

    class Test
    {
        public int Id { get; set; }
        public Test()
        { }
    }

}
