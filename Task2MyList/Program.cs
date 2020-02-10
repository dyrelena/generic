using System;
using System.Collections.Generic;

namespace Task2MyList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MyList<int> test1 = new MyList<int>();
            test1.Add(5);
            test1.Add(7);
            test1.Add(10);

            for (int i = 0; i < test1.ListLength; i++)
            {
                Console.WriteLine(" " + test1[i]);
            }

            Console.WriteLine($" Number of items in the list: {test1.ListLength}");
            Console.ReadLine();           
        }
    }

    class MyList<T>
    {
        public T[] listElems;
        public int ListLength { get { return listElems.Length; } } //общее количество элементов

        public MyList()
        {
            listElems = new T[0];
        }
        
        //добавление элемента
        public void Add(T val)
        {   
            Array.Resize(ref listElems, listElems.Length + 1);
            listElems[listElems.Length-1] = val;
            
        }
        
        //индексатор
        public T this [int index]
        {
            get {return listElems[index];}
        }
    }
}
