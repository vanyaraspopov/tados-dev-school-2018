using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;

namespace TadosDevSchool2018.Models.Task2
{
    public class Category : PassiveRecord<Category>
    {
        protected override string Table
        {
            get
            {
                return "categories";
            }
        }

        public int Id { get; set; }

        /// <summary>
        /// Название категории Статья|Видео|Галерея
        /// </summary>
        public string Title { get; set; }
    }

    public class CategoryVar : PassiveRecord<CategoryVar>
    {
        protected override string Table
        {
            get
            {
                return "category_vars";
            }
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public Category Category
        {
            get
            {
                return Category.Get(CategoryId);
            }
        }

    }

    public class CategoryVarValue : PassiveRecord<CategoryVarValue>
    {
        protected override string Table
        {
            get
            {
                return "category_vars_values";
            }
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ContentId { get; set; }
        public string Value { get; set; }

        public Category Category
        {
            get
            {
                return Category.Get(CategoryId);
            }
        }
        public Content Content
        {
            get
            {
                return Content.Get(ContentId);
            }
        }
    }

    public class Content : PassiveRecord<Content>
    {
        protected override string Table
        {
            get
            {
                return "contents";
            }
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        public Category Category
        {
            get
            {
                return Category.Get(CategoryId);
            }
        }
        public User Author
        {
            get
            {
                return User.Get(AuthorId);
            }
        }
    }

    public class ContentRate : PassiveRecord<ContentRate>
    {
        protected override string Table
        {
            get
            {
                return "content_rates";
            }
        }

        public int Id { get; set; }
        public int ContentId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }

        public Content Content
        {
            get
            {
                return Content.Get(ContentId);
            }
        }
        public User User
        {
            get
            {
                return User.Get(UserId);
            }
        }
    }

    public class User : PassiveRecord<User>
    {
        protected override string Table
        {
            get
            {
                return "users";
            }
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Settlement { get; set; }
    }
}
