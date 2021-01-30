using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Task1.Models;

namespace Task1
{
    class CollectionsShowWorking
    {
        public void ShowArrayList()
        {
            Collections currentCollection = Collections.ArrayList;
            Delimiter(currentCollection);
            ArrayList arrayList = new ArrayList()
            {
                "String1",
                "String22",
                "String333",
                123.546
            };

            arrayList.Add(1);
            arrayList.Add('c');
            WriteLineAfterAddEl(currentCollection);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }


            arrayList.Remove(1);
            arrayList.RemoveAt(0);

            WriteLineAfterDelEl(currentCollection);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            var unexistElement = 100;
            try
            {

                Console.WriteLine($"\nTry Delete {unexistElement} ");
                arrayList.RemoveAt(unexistElement);
            }
            catch (Exception)
            {
                Console.WriteLine($"{unexistElement} doesn't exist");
            }
            Delimiter(currentCollection);
        }

        public void ShowList()
        {
            Collections currentCollection = Collections.List;
            List<String> list = new List<String>();
            var string3 = "String333";

            list.Add("String1");
            list.Add("String22");
            list.Add(string3);

            Delimiter(currentCollection);
            WriteLineAfterAddEl(currentCollection);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Remove(list[0]);
            list.Remove(string3);

            WriteLineAfterDelEl(currentCollection);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var unexistElement = 100;
            try
            {
                Console.WriteLine($"\nTry Delete {unexistElement} ");
                list.RemoveAt(unexistElement);
            }
            catch (Exception)
            {
                Console.WriteLine($"{unexistElement} doesn't exist");
            }

            Delimiter(currentCollection);
        }

        public void ShowListLinked()
        {

            Collections currentCollection = Collections.LinkedList;
            LinkedList<String> linkedList = new LinkedList<String>();
            linkedList.AddFirst("String22");
            linkedList.AddBefore(linkedList.First, "String1");
            linkedList.AddAfter(linkedList.Find("String22"), "String333");
            linkedList.AddLast("String55555");
            linkedList.AddLast("String666666");
            linkedList.AddLast("String7777777");
            linkedList.AddLast("String88888888");
            linkedList.AddLast("String999999999");
            linkedList.AddLast("String1010101010");
            linkedList.AddLast("String11111111111");

            LinkedListNode<String> current = linkedList.First;
            Delimiter(currentCollection);
            WriteLineAfterAddEl(currentCollection);
            for (int i = 0; i < linkedList.Count; i++)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine("\nGet midle element LinkedList");
            LinkedListNode<String> midleElement = linkedList.First;
            for (int i = 0; i < (linkedList.Count - 1) / 2; i++)
            {
                midleElement = midleElement.Next;
            }
            Console.WriteLine($"Midle element = {midleElement.Value}");

            linkedList.RemoveFirst();
            LinkedListNode<String> linkedListNode = linkedList.First; ;
            linkedList.Remove(linkedListNode);
            linkedList.Remove("String4444");
            WriteLineAfterDelEl(currentCollection);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Delimiter(currentCollection);
        }


        public void ShowStack() 
        {
            Collections currentCollection = Collections.Stack;
            Stack<String> stack = new Stack<String>();

            stack.Push("String1");
            stack.Push("String22");
            stack.Push("String333");
            stack.Push("String4444");
            Delimiter(currentCollection);
            WriteLineAfterAddEl(currentCollection);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            WriteLineAfterDelEl(currentCollection);
            stack.Pop();
            stack.Pop();
            for (int i = stack.Count; i > 0; i--)
            {
                Console.WriteLine(stack.Peek());
                stack.Pop();
            }
            Delimiter(currentCollection);
        }

        public void ShowQueue()
        {
            Collections currentCollection = Collections.Queue;
            Queue<String> queue = new Queue<String>();

            queue.Enqueue("String1");
            queue.Enqueue("String22");
            queue.Enqueue("String333");
            queue.Enqueue("String4444");
            Delimiter(currentCollection);
            WriteLineAfterAddEl(currentCollection);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            WriteLineAfterDelEl(currentCollection);
            queue.Dequeue();
            queue.Dequeue();
            for (int i = queue.Count; i > 0; i--)
            {
                Console.WriteLine(queue.Peek());
                queue.Dequeue();
            }
            Delimiter(currentCollection);
        }

        public void ShowHashTable()
        {
            Collections currentCollection = Collections.HashTable;
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "First");
            hashTable.Add("Second", 2);
            hashTable.Add("half", 0.5);
            hashTable.Add("4", "String4444");
            Delimiter(currentCollection);
            WriteLineAfterAddEl(currentCollection);
            ICollection keys = hashTable.Keys;
            ArrayList arrayListKeys = new ArrayList(keys);
            for (int i = 0; i < arrayListKeys.Count; i++)
            {
                Console.WriteLine($"{arrayListKeys[i]}: {hashTable[arrayListKeys[i]]}");
            }

            hashTable.Remove(1);
            hashTable.Remove("4");
            WriteLineAfterDelEl(currentCollection);
            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine($"{key}: {hashTable[key]}");
            }
            Delimiter(currentCollection);
        }

        public void ShowDictionary() 
        {
            Collections currentCollection = Collections.Dictionary;
            Dictionary<IKey, IValue> dictionary = new Dictionary<IKey, IValue>();
            var ROO = new Organization(11111222, "Отдел образования");
            var BRSM = new Organization(33333444, "БРСМ");
            var III = new Craftman("Деревяные столы", 12121212, "Иванов Иван Иванович");

            var contractROO = new Contract("111-22/12", 1, 756.02);
            var contractBRSM = new Contract("333-44/34", 2, 342.50);

            dictionary.Add(ROO, contractROO);
            dictionary.Add(BRSM, contractBRSM);
            dictionary.Add(new Organization(55555666, "Финансовый отдел"),
                new Contract("555-66/56", 3, 4334.12));
            dictionary.Add(new Organization(77777888, "Казначейство"),
                new Contract("777-88/78", 4, 0));
            dictionary[III] = new ContractCraftman("121-12/12", 205.10, 20);
            
            Delimiter(currentCollection);
            WriteLineAfterAddEl(Collections.Dictionary);
            foreach (KeyValuePair<IKey, IValue> pair in dictionary)
            {
                Console.WriteLine($"{pair.Key.GetFullName()} \n \t {pair.Value.GetInfoForOrg()} ");
            }

            dictionary.Remove(ROO);
            dictionary.Remove(III);

            var keys = dictionary.Keys;
            ArrayList arrayKeys = new ArrayList(keys);

            WriteLineAfterDelEl(Collections.Dictionary);
            for (int i = 0; i < arrayKeys.Count; i++)
            {
                Console.WriteLine($"{((IKey)arrayKeys[i]).GetFullName()} \n \t" +
                    $" {(dictionary[(IKey)arrayKeys[i]]).GetInfoForOrg()} ");
            }
            Delimiter(currentCollection);
        }

        private void Delimiter(Collections collection) 
        {
            Console.WriteLine($"=========================={collection}==========================");
        }
        private void WriteLineAfterAddEl(Collections collection)
        {
            Console.WriteLine($"\n{collection} after Add");
        }

        private void WriteLineAfterDelEl(Collections collection)
        {
            Console.WriteLine($"\n{collection} after Delete");
        }
    }
}

