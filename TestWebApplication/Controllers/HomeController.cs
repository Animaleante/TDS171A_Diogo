using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApplication.Contexts;

namespace TestWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Categorias = context.Categorias.OrderBy(c => c.Nome).ToArray();
            ViewBag.Fabricantes = context.Fabricantes.OrderBy(c => c.Nome).ToArray();
            ViewBag.Produtos = context.Produtos.Include(c => c.Categoria).Include(f => f.Fabricante).OrderBy(n => n.Nome);

            return View(context.Categorias);
        }
    }
}