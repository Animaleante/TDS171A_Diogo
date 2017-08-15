using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDS171A_Diogo.Models;

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
    }
}