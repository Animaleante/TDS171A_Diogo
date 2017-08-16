using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDS171A_Diogo.Models;
using TDS171A_Diogo.Utils;

namespace TDS171A_Diogo.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList = new List<Category>() {
            new Category() { CategoryId = 1, Name = "Ruivas", Description = "Mulheres tocadas pelo fogo", CategorySlug = "ruivas" },
            new Category() { CategoryId = 2, Name = "Morenas", Description = "Mulheres do jeito certo", CategorySlug = "morenas" },
            new Category() { CategoryId = 3, Name = "Loiras", Description = "Mulheres meh...", CategorySlug = "loiras" }
        };

        // GET: Categories
        public ActionResult Index()
        {
            return View(categoryList.OrderBy(c => c.Name));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            categoryList.Add(category);

            category.CategoryId = categoryList.Max(c => c.CategoryId + 1);
            category.CategorySlug = category.Name.GenerateSlug();

            return RedirectToAction("Create");
        }

        public ActionResult Details(string id)
        {
            var category = categoryList
                .Where(c => c.CategorySlug == id)
                .First();

            category = categoryList
                .First(c => c.CategorySlug == id);

            return View(category);
        }

        /*public ActionResult Details(long id)
        {
            var category = categoryList
                .Where(c => c.CategoryId == id)
                .First();

            return View(category);
        }*/

        public ActionResult Edit(long id)
        {
            var category = categoryList
                .Where(c => c.CategoryId == id)
                .First();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category modified)
        {
            var category = categoryList
                .Where(c => c.CategoryId == modified.CategoryId)
                .First();

            category.Name = modified.Name;
            category.Description = modified.Description;

            return RedirectToAction("Index");
        }
    }
}