using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.BookStore.Models;
using Demo.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Demo.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRespository _bookRespository = null;
        public BookController()
        {
            _bookRespository = new BookRespository();
        }
        public ViewResult GetAllBooks()
        {
            var data= _bookRespository.GetAllBooks().ToList();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data= _bookRespository.GetBookById(id);

            return View(data);
        }
        public List<BookModel> searchBooks(string bookName,string autherName)
        {
            return _bookRespository.SearchBook(bookName, autherName).ToList();
        }

    }
}
