using System;
using System.Collections.Generic;

namespace Task3MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            
            MyDictionary<int, string> test1 = new MyDictionary<int, string>();
            test1.Add(1, "a");
            test1.Add(2, "a");
            for (int i = 0; i < test1.MyLength; i++)
            {
                Console.WriteLine(test1[i]);
            }
        }
    }

    class MyDictionary<TKey, TValue>
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
            if (myDictionaryElems.Exists(x => x.Key.Equals(key)))
            {
                throw new Exception();
            }
            else
            {
                myDictionaryElems.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
        }

        //индексатор
        public List<KeyValuePair<TKey, TValue>> this [TKey key]
        {
            get { return myDictionaryElems[key]; }
        }
    }
}
