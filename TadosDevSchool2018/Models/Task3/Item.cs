using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task3
{
    public abstract class Item
    {
        public Author Author { get; set; }

        public Item(Author author)
        {
            this.Author = author;
        }
    }
}
