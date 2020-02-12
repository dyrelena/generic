using System;
using System.Collections;


namespace Task7ArrayList
{
    public class Program
    {
        public static void Main()
        {
            ArrayList test = new ArrayList();
            test.Add(1);
            test.Add("two");
            test.Add(3.2);
            test.Add("ddd");
            test.PrintContent();

            Console.WriteLine("\nInsert new value at position 2");
            test.Insert(1, "new");
            test.PrintContent();
            Console.WriteLine("\nRemove value from position 3");
            test.RemoveAt(2);
            test.PrintContent();
            Console.WriteLine("\nRemove value \"new\"");
            test.RemoveVal("new");
            test.PrintContent();

            Console.WriteLine("\nClear the list");
            test.Clear();
            test.PrintContent();
            Console.ReadLine();
        }
    }

    public class ArrayList // : IList
    {
        private object[] _arrayList;
        public int MyLength { get { return _arrayList.Length; } }
        private int _index = 0;

        public ArrayList()
        {
            _arrayList = new object[1];
        }

        public int Add(object elem)
        {
            if (_index >= MyLength)
            {
                Array.Resize(ref _arrayList, (MyLength * 2));
            }

            if (_index < MyLength)
            {
                _arrayList[_index] = elem;
                _index++;



                return (_index - 1);
            }

            return -1;
        }

        public void Clear()
        {
            Array.Resize(ref _arrayList, 0);
        }

        public object this[int index]
        {
            get { return _arrayList[index]; }
        }


        public bool Contains(object value)
        {
            for (int i = 0; i < MyLength; i++)
            {
                if (_arrayList[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int MyIndexOf(object value)
        {
            for (int i = 0; i < MyLength; i++)
            {
                if (_arrayList[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public IEnumerator GetEnumerator()
        {
            return _arrayList.GetEnumerator();
        }

        public void Insert(int index, object value)
        {
            Array.Resize(ref _arrayList, MyLength + 1);

            _arrayList[MyLength - 1] = _arrayList[MyLength - 2];
            if ((_index + 1 <= MyLength) && (index < MyLength) && (index >= 0))
            {


                for (int i = MyLength - 1; i >= index; i--)
                {
                    _arrayList[i] = _arrayList[i - 1];
                }

                _arrayList[index] = value;
            }
        }

        public void PrintContent()
        {
            Console.WriteLine("List has a capacity of {0} and list contents: ", MyLength);
            foreach (object elem in _arrayList)
            {
                Console.WriteLine(elem);
            }
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < MyLength))
            {
                for (int i = index; i < MyLength - 1; i++)
                {
                    _arrayList[i] = _arrayList[i + 1];
                }
            }

            Array.Resize(ref _arrayList, MyLength - 1);
        }

        public void RemoveVal(object value)
        {
            RemoveAt(MyIndexOf(value));
        }
    }


}
