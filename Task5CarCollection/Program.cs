using System;
using System.Collections.Generic;

namespace Task5CarCollection
{
    public class Program
    {
        public static void Main()
        {
            CarCollection<Car> myCars = new CarCollection<Car>();
            myCars.Add("name1", 2019);
            myCars.Add("name2", 2019);
            myCars.Add("name3", 2019);

            myCars.CarsPrint<Car>();
            myCars.Clear();

            
            myCars.CarsPrint<Car>();
        }
    }

    interface ICar
    {
        string Name { get; set; }
        int Year { get; set; }
    }

    class CarCollection<T> where T : ICar, new()
    {
        public List<T> carCollection;
        public int Length { get { return carCollection.Count; } } //общее количество элементов

        public CarCollection()
        {
            carCollection = new List<T>();
        }

        //метод добавления машин
        public void Add(string Name, int Year)
        {
            carCollection.Add(new T() { Name = Name, Year = Year });
        }

        //индексатор
        public T this[int i]
        {
            get { return carCollection[i]; }

        }

        //вывод на печать содержимого коллекции
        public void CarsPrint<CT>() where CT : ICar
        {
            Console.WriteLine("Collection of type: " + typeof(CT).Name);
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(carCollection[i]);
            }
        }

        //удаление всех машин
        public void Clear()
        {
            carCollection.Clear();
            Console.WriteLine("\nCollection is cleared");
        }
    }

    class Car : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return System.String.Format((Name + ", " + Year));
        }
    }

}
