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

        public static List<Author> HelperGenerateAuthors()
        {
            var names = new[] {
                "Alpha1", "Bravo1", "Charlie1", "Delta1", "Echo1",
                "Alpha2", "Bravo2", "Charlie2", "Delta2", "Echo2",
                          "Bravo3", "Charlie3"
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
