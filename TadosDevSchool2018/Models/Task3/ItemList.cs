using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task3
{
    public partial class ItemList<T> : IEnumerable<T>
        where T : Item
    {
        //  Реализация списка нагло стырена остюда 
        //  https://ulearn.me/Course/BasicProgramming2/Listy_i_indeksatsiya_ff0b5f9b-eb8c-432d-8bab-4bfa9718469a

        public T[] collection;
        public int Count { get; private set; }

        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string order;

        public ItemList()
        {
            collection = new T[100];
            order = getEnumerationOrder(alphabet);
        }

        void Enlarge()
        {
            var _collection = new T[collection.Length * 2];
            for (var i = 0; i < collection.Length; i++)
            {
                _collection[i] = collection[i];
            }
            collection = _collection;
        }

        public void Add(T value)
        {
            if (Count == collection.Length)
                Enlarge();
            collection[Count++] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (order.Length == 0)
            {
                throw new Exception("Свойство order не должно быть пустым");
            }
            for (int i = 0; i < order.Length; i++)
            {
                var items = getItemsByAuthorLetter(order[i], collection);
                for (var k = 0; k < items.Count; k++)
                {
                    yield return items[k];
                }
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
                return collection[index];
            }
            set
            {
                if (index < 0 || index >= Count) throw new IndexOutOfRangeException();
                collection[index] = value;
            }
        }

        private string getEnumerationOrder(string alphabet)
        {
            var order = "";
            var i = 0;
            var k = alphabet.Length - 1;
            while (i <= k)
            {
                order += alphabet[i];
                if (i == k)
                {
                    break;
                }
                order += alphabet[k];

                i++;
                k--;
            }
            return order;
        }

        private List<T> getItemsByAuthorLetter(char letter, T[] items)
        {
            var list = new List<T>();
            foreach (var item in items)
            {
                var authorName = item.Author.Name;
                if (authorName.Length > 0 && authorName[0] == letter)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
