using System;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCollection<string> stringCollection = GetStringCollection();
            Console.WriteLine($"Test string");
            stringCollection.ShowCollection();

            stringCollection.TestDelete();
            stringCollection.ShowCollection();

            Console.WriteLine($"Test int");
            TestCollection<int> intCollection = GetIntCollection();
            intCollection.ShowCollection();

            intCollection.TestDelete();
            intCollection.ShowCollection();
        }

        private static TestCollection<string> GetStringCollection() 
        {
            TestCollection<string> collection = new TestCollection<string>();

            collection.Add("1");
            collection.Add("2");
            collection.Add("3");
            collection.Add("4");
            collection.Add("5");
            collection.Add("6");
            return collection;
        }

        private static TestCollection<int> GetIntCollection()
        {
            TestCollection<int> collection = new TestCollection<int>();

            collection.Add(11);
            collection.Add(22);
            collection.Add(33);
            collection.Add(44);
            collection.Add(55);
            collection.Add(66);
            collection.Add(77);
            return collection;
        }
    }
}

