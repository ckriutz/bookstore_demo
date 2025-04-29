using Microsoft.AspNetCore.Mvc;

namespace bookstore_demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookDatabase _bookDatabase;

        public HomeController(IBookDatabase bookDatabase)
        {
            _bookDatabase = bookDatabase;
        }

        public IActionResult Index()
        {
            var featuredBooks = _bookDatabase.GetAllBooks().ToList();
            return View(featuredBooks);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}