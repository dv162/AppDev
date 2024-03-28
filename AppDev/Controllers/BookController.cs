using AppDev.Models;
using AppDev.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace AppDev.Controllers
{
    public class BookController : Controller
    {

        private readonly IBookRepository _BookRepository;
        public BookController(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }
        public IActionResult Index()
        {
            List<Book> books = _BookRepository.GetAll().ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (book.Title == book.Description)
            {
                ModelState.AddModelError("Description", "Description must be different than Name");
            }
            if (ModelState.IsValid)
            {
                _BookRepository.Add(book);
                _BookRepository.Save();
                TempData["Success"] = "Add Book Success";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Book? book = _BookRepository.Get(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                _BookRepository.Update(book);
                _BookRepository.Save();
                TempData["Success"] = "Edit Book Success";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Book? book = _BookRepository.Get(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {

            _BookRepository.Delete(book);
            _BookRepository.Save();
            TempData["Success"] = "Delete Book Success";
            return RedirectToAction("Index");
        }
        public void SetViewBag() { 
        }
    }
}