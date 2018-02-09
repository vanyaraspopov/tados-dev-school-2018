using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task3
{
    public class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }

        public static List<Author> _GenerateAuthors()
        {
            var names = new[] {
                "A1", "B1", "C1", "D1", "E1", "X1", "Y1", "Z1",
                "A2", "B2", "C2", "D2", "E2", "X2", "Y2", "Z2",
                "A3", "B3", "C3", "D3", "E3", "X3", "Y3", "Z3"
            };
            var authors = new List<Author>();
            foreach (var name in names)
            {
                authors.Add(new Author(name));
            }
            return authors;
        }
    }
}
