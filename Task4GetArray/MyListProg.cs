using System;
using System.Collections.Generic;

namespace Task2MyList
{
    

   public class MyList<T>
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
