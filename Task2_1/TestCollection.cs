using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyCollection
{
    class TestCollection<T> : IEnumerable
    {
        private List<T> _list;

        public TestCollection()
        {
            _list = new List<T>();
        }

        public TestCollection(List<T> list)
        {
            _list = list;
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(_list);
        }
        /// <summary>
        /// Add new element if type is equal
        /// </summary>
        /// <param name="newElement"></param>
        public bool Add(T newElement)
        {
            if (typeof(T) == newElement.GetType())
            {
                _list.Add(newElement);
                return true;
            }
            Console.WriteLine($"{newElement} неверный формат");
            return false;
        }
        /// <summary>
        /// Remove element from collection if size > 5
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool Remove(int index)
        {
            const int limit = 5;
            if (_list.Count > limit)
            {
                _list.RemoveAt(index);
                return true;
            }
            Console.WriteLine($"В коллекции осталось {_list.Count} при лимите в {limit}.");
            return false;
        }
        public class Iterator : IEnumerator
        {
            private List<T> _list;
            private int _index = -1;

            public Iterator(List<T> list)
            {
                _list = list;
            }

            public object Current
            {
                get
                {
                    return _list[_index];
                }
            }

            public bool MoveNext()
            {
                if (_index < _list.Count - 1)
                {
                    _index++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _index = -1;
            }
        }
        /// <summary>
        /// Show full collection
        /// </summary>
        public void ShowCollection()
        {
            Console.WriteLine("Вывод колекции");
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// Try remove 1,3,5 element
        /// </summary>
        public void TestDelete()
        {
            Console.WriteLine("Удаление");
            this.Remove(1);
            this.Remove(3);
            this.Remove(5);
        }
    }
}
