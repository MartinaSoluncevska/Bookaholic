using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookaholicFin.Models;


namespace BookaholicFin.Controllers
{
    public class StoreController : Controller
    {
        BookStoreEntities storeDB = new BookStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Books")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            var book = storeDB.Books.Find(id);

            return View(book);
        }

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();

            return PartialView(genres);
        }
    }
}