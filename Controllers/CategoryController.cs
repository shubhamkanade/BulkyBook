using BulkyBook.Data;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category o)
        {

            if(o.Name == o.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "name and displayOrder cannot be empty");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Add(o);
                _db.SaveChanges();
                TempData["Success"] = "Category Added Successfully";
                return RedirectToAction("Index");


            }
            return View(o);
        }

        public IActionResult Edit(int? id)
        {
            if (id == 0 || id == null)
                return NotFound();

            var category = _db.Categories.Find(id);

            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category o)
        {

            if (o.Name == o.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "name and displayOrder cannot be empty");
            }
            if (ModelState.IsValid)
            {
                //var category = _db.Categories.Find(o.Id);

                //category.Name = o.Name;
                //category.DisplayOrder = o.DisplayOrder;

                _db.Categories.Update(o);
                _db.SaveChanges();
                TempData["Success"] = "Category Updated Successfully";

                return RedirectToAction("Index");

            }
            return View(o);
        }

        public IActionResult Remove(int? id)
        {
            if (id == 0 || id == null)
                return NotFound();

            var category = _db.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
                var category = _db.Categories.Find(id);

                _db.Categories.Remove(category);
                _db.SaveChanges();
                TempData["Success"] = "Category Deleted Successfully";

            return RedirectToAction("Index");
        }

    }
}
