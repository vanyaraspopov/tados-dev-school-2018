using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task3
{
    public class Book : Item
    {
        public Book() { }
        public Book(Author author) : base(author) { }
    }
}
