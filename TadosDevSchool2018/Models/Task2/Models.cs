using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task2
{
    public class Category
    {
        public int Id { get; set; }

        /// <summary>
        /// Название категории Статья|Видео|Галерея
        /// </summary>
        public string Title { get; set; }
    }

    public class CategoryVar
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }

    public class CategoryVarValue
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }
    }

    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }
    }

    public class ContentRate
    {
        public int Id { get; set; }
        public int Rate { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Settlement { get; set; }
    }
}
