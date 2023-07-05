using LibraryMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMVC.Controllers
{
    public class AppController : Controller
    {
        private static List<BookViewModel> _books = new List<BookViewModel>();
        public IActionResult Index()
        {
            return View(_books);
        }

        public IActionResult AddOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                _books.Add(model);
                return Redirect(nameof(Index));
            }
            return View();
        }

        [HttpGet("customers")]
        public IActionResult Customers()
        {
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            // throw new InvalidOperationException();
            return View();
        }
    }
}
