using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookaholicFin.Models;

namespace BookaholicFin.Controllers
{
    [Authorize(Users = "admin@gmail.com")]
    public class BookStoreManagerController : Controller
    {

        private BookStoreEntities db = new BookStoreEntities();

        // GET: BookStoreManager
        public ViewResult Index()
        {
            var books = db.Books.Include(a => a.Genre).Include(a => a.Author);
            return View(books.ToList());
        }

        // GET: BookStoreManager/Details/5
        public ViewResult Details(int id)
        {
            Book book = db.Books.Find(id);
            return View(book);
        }

        // GET: BookStoreManager/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name");
            return View();
        }

        // POST: BookStoreManager/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", book.GenreId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }
      
        // GET: BookStoreManager/Delete/5
        public ActionResult Delete(int id)
        {
            Book book= db.Books.Find(id);
            return View(book);
           
        }

        // POST: BookStoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
