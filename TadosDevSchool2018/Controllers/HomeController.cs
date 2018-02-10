using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using TadosDevSchool2018.Models.Task3;

namespace TadosDevSchool2018.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Task1();
            Task2();
            Task3();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }


        private void Task1()
        {
            var dataPrefix = "task1.";

            string projectDir = System.IO.Directory.GetCurrentDirectory();
            string path = projectDir + @"\Models\Task1\Smallfuck.cs";

            ViewData[dataPrefix + "file"] = path;

            // Open the file to read from.
            string[] readText = System.IO.File.ReadAllLines(path);
            string code = "";
            foreach (string s in readText)
            {
                code += "\n" + s;
            }
            var match = Regex.Match(code, @"/^\.$/");

            ViewData[dataPrefix + "code"] = code;
        }

        private void Task2()
        {
            var dataPrefix = "task2.";

            var queryA = "SELECT FROM ";
        }

        private void Task3()
        {
            var dataPrefix = "task3.";
            uint itemsCount = 10;

            //  Генерация авторов и предметов
            var authors = Author._GenerateAuthors();
            var books = Item._GenerateItemList<Book>(itemsCount, authors);

            //  Перебор предметов "в странном порядке"
            var enumeratedBooks = new List<Book>();
            foreach (var book in books)
                enumeratedBooks.Add(book);

            //  Полный список авторов
            var authorNames = "";
            for (var i = 0; i < authors.Count; i++)
            {
                if (i > 0) authorNames += ", ";
                authorNames += authors[i].Name;
            }
            ViewData[dataPrefix + "authors"] = authorNames;

            //  Список авторов созданных предметов "в странном порядке"
            var enumeratedAuthorNames = "";
            for (var i = 0; i < enumeratedBooks.Count; i++)
            {
                if (i > 0) enumeratedAuthorNames += ", ";
                enumeratedAuthorNames += enumeratedBooks[i].Author.Name;
            }
            ViewData[dataPrefix + "enumeratedAuthors"] = enumeratedAuthorNames;

            ViewData[dataPrefix + "itemsCount"] = itemsCount;
        }
    }
}
