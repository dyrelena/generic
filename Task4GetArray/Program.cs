using System;
using Task2MyList;

namespace Task4GetArray
{
    class Program
    {
        static void Main(string[] args)
        {


            MyList<int> test1 = new MyList<int>();
            test1.Add(5);
            test1.Add(7);
            test1.Add(10);

            Console.WriteLine(" Array from List:");
            //массив из списка и выводим на печать    
            int[] testArr = test1.GetArray();

            foreach (int elem in testArr)
            {
                Console.WriteLine(" " + elem);
            }

            Console.ReadLine();
        }
    }

    //метод расширения - получить массив из списка
    public static class ArrayExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] _list = new T[list.ListLength];
            for (int i = 0; i < list.ListLength; i++)
            {
                _list[i] = list[i];
            }
            return _list;
        }
    }

}
