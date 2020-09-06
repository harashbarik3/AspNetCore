using Demo.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.BookStore.Repository
{
    public class BookRespository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.auther == authorName).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",auther="Harash"},
                new BookModel(){Id=2,Title="MVC",auther="Harash"},
                new BookModel(){Id=3,Title="C#",auther="hari"},
                new BookModel(){Id=4,Title="Java",auther="john"},
                new BookModel(){Id=5,Title="Python",auther="john"}
            };
        }
    }
}
