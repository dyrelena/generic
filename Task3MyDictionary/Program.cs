using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> test1 = new MyDictionary<int, string>();
            test1.Add(1, "one");
            test1.Add(2, "two");
            test1.Add(3, "three");

            foreach (var x in test1)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine($"Number of items: {test1.MyLength}\n");

            do
            {
                Console.Write("Enter the key: ");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The value for key {key} is: {test1[key]}");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

           // Console.ReadLine();
        }
    }

    class MyDictionary<TKey, TValue> : IEnumerable
    {
        public List<KeyValuePair<TKey, TValue>> myDictionaryElems;
        public int MyLength { get { return myDictionaryElems.Count; } } //общее количество элементов
        
        public MyDictionary()
        {
            myDictionaryElems = new List<KeyValuePair<TKey, TValue>>();
        }

        //добавление элемента
        public void Add(TKey key, TValue value)
        {
            if (KeyExist(key))
            {
                throw new Exception("Error 1");
            }
            else
            {
                myDictionaryElems.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
        }

        
        private bool KeyExist(TKey key)
        {
            return myDictionaryElems.Exists(x => x.Key.Equals(key));
        }

        public TValue GetValue(TKey key)
        {
            if(KeyExist(key))
            {
                return myDictionaryElems.Find(x => x.Key.Equals(key)).Value;
            }
            else
            {
                throw new Exception("Error2");
            }
        }

        public IEnumerator GetEnumerator()
        {   
            return myDictionaryElems.GetEnumerator();
        }

        //индексатор
        public TValue this [TKey key]
        {
            get { return GetValue(key); }
        }

        
    }
}
