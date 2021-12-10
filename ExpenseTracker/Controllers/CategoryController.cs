using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ExpenseTrackDbContext _db;
        public CategoryController(ExpenseTrackDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _db.Categories;
            return View(categories);
        }
        //Get-Create
        public ActionResult Create()
        {
            return View();
        }

        //Post-Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                if (_db.Categories.Any(x => x.CategoryName.ToLower() == category.CategoryName.ToLower()))
                {
                    ModelState.AddModelError("", "Already exits");
                    return View(category);
                }
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //Get-Edit
        public ActionResult Edit(int id)
        {
            return View(_db.Categories.FirstOrDefault(x => x.CategoryId == id));
        }

        //Post-Edit
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                if (_db.Categories.Any(x => x.CategoryName.ToLower() == category.CategoryName.ToLower()))
                {
                    ModelState.AddModelError("", "Already exits");
                    return View(category);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //Get-Delete
        public ActionResult Delete(int id)
        {
            return View(_db.Categories.FirstOrDefault(x => x.CategoryId == id));
        }

        //Post-Delete
        [HttpPost, ActionName("Delete")]
        public ActionResult DoDelete(int id)
        {
            var expense = new Category { CategoryId = id };
            _db.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
