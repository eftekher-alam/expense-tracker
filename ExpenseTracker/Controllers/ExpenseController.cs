using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ExpenseTrackDbContext _db;
        public ExpenseController(ExpenseTrackDbContext db) 
        {
            _db = db; 
        }
        public IActionResult Index(DateTime? from, DateTime? to)
        {
            if (from.HasValue && to.HasValue)
            {
                var data = _db.Expenses
                    .Include(x => x.Category)
                    .Where(x => x.Date.Date >= from.Value.Date && x.Date.Date <= to.Value.Date)
                    .ToList();
                return View(data);
            }
            else
            {
                var data = _db.Expenses.Include(x => x.Category).ToList();
                return View(data);
            }

        }

        //Get-Create
        public ActionResult Create()
        {
            ViewBag.Categories = _db.Categories.ToList();
            return View();
        }

        //Post-Create
        [HttpPost]
        public ActionResult Create(Expense expense)
        {
            ViewBag.Categories = _db.Categories.ToList();
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(expense);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(expense);
        }

        //Get-Create
        public ActionResult Edit(int id)
        {
            ViewBag.Categories = _db.Categories.ToList();
            return View(_db.Expenses.FirstOrDefault(x => x.ExpenseId == id));
        }

        //Post-Create
        [HttpPost]
        public ActionResult Edit(Expense expense)
        {
            ViewBag.Categories = _db.Categories.ToList();
            if (ModelState.IsValid)
            {
                _db.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }            
            return View(expense);
        }

        //Get-Delete
        public ActionResult Delete(int id)
        {
            return View(_db.Expenses.Include(x => x.Category).FirstOrDefault(x => x.ExpenseId == id));
        }

        //Post-Delete
        [HttpPost, ActionName("Delete")]
        public ActionResult DoDelete(int id)
        {
            var expense = new Expense { ExpenseId = id };
            _db.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
