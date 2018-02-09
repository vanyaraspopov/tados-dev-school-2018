using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task3
{
    public class Painting : Item
    {
        public Painting() { }
        public Painting(Author author) : base(author) { }
    }
}
