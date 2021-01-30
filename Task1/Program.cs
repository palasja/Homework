using System;
using System.Collections;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionsShowWorking showWorking = new CollectionsShowWorking();
            showWorking.ShowArrayList();
            showWorking.ShowList();
            showWorking.ShowListLinked();
            showWorking.ShowStack();
            showWorking.ShowQueue();
            showWorking.ShowHashTable();
            showWorking.ShowDictionary();
        }
    }
}
