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
                new BookModel(){Id=1,Title="MVC",auther="Smith",Description="This is MVC BOOK",Category="Programming",Language="English",Totalpages=590},
                new BookModel(){Id=2,Title="Angular",auther="Mike",Description="This is Angular Book",Category="Science",Language="Hindi",Totalpages=700},
                new BookModel(){Id=3,Title="C#",auther="hari",Description="This is C# book",Category="Maths",Language="English",Totalpages=809},
                new BookModel(){Id=4,Title="Java",auther="john",Description="THis is a Java book",Category="Bio",Language="English",Totalpages=600},
                new BookModel(){Id=5,Title="Python",auther="john",Description="This is a Python BOok",Category="History",Language="japnees",Totalpages=453},
                new BookModel(){Id=6,Title="Azure DevOps",auther="lena",Description="This is a Azure DevOps BOok",Category="Maths",Language="English",Totalpages=809}
                
            };
        }
    }
}
