using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task3
{
    public abstract class Item
    {
        public Author Author { get; set; }

        public Item() { }
        public Item(Author author)
        {
            this.Author = author;
        }

        public static ItemList<T> _GenerateItemList<T>(uint max, List<Author> authors)
            where T : Item, new()
        {
            var rand = new Random();
            Func<List<Author>, Author> randomAuthor = (_authors) =>
            {
                var i = rand.Next(_authors.Count);
                return _authors[i];
            };

            var list = new ItemList<T>();
            for (var i = 0; i < max; i++)
            {
                var item = new T();
                item.Author = randomAuthor(authors);
                list.Add(item);
            }
            return list;
        }
    }
}
