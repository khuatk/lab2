using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab2.Models;
using System.Data.Entity.Infrastructure;

namespace lab2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "One Piece", "Oda", "/Content/img/2.jpg"));
            books.Add(new Book(2, "Dragon Ball", "Taka", "/Content/img/3.jpg"));
            books.Add(new Book(3, "Naruto", "Shin", "/Content/img/4.jpg"));
            return View(books);
        }


        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "One Piece", "Oda", "/Content/img/2.jpg"));
            books.Add(new Book(2, "Dragon Ball", "Taka", "/Content/img/3.jpg"));
            books.Add(new Book(3, "Naruto", "Shin", "/Content/img/4.jpg"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int id, string name, string tacgia, string img_cover)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "One Pice chapter 1", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(2, "One Pice chapter 2", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(3, "One Pice chapter 3", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(4, "One Pice chapter 4", "Oda", "/Content/img/1.jpg"));
            Book book = new Book();
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Name = name;
                    b.Tacgia = tacgia;
                    b.Img_cover = img_cover;
                    break;
                }
            }

            return View("Index", books);
        }
        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]

        public ActionResult ConTact([Bind(Include = " Id, Name, Tacgia,Img_cover")]Book book)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "One Pice chapter 1", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(2, "One Pice chapter 2", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(3, "One Pice chapter 3", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(4, "One Pice chapter 4", "Oda", "/Content/img/1.jpg"));
            try
            {

                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Error");
            }

            return View("Index", books);
        }
        public ActionResult DeleteBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "One Pice chapter 1", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(2, "One Pice chapter 2", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(3, "One Pice chapter 3", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(4, "One Pice chapter 4", "Oda", "/Content/img/1.jpg"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                }
            }

            return View(book);
        }
        [HttpPost, ActionName("DeleteBook")]
        [ValidateAntiForgeryToken]
        public ActionResult delete(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "One Pice chapter 1", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(2, "One Pice chapter 2", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(3, "One Pice chapter 3", "Oda", "/Content/img/1.jpg"));
            books.Add(new Book(4, "One Pice chapter 4", "Oda", "/Content/img/1.jpg"));
            Book book = new Book();
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    DeleteBook(b.Id);
                    break;
                }
            }

            return View("Index", books);
        }


    }
}