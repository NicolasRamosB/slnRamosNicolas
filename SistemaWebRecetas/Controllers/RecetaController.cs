using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebRecetas.Data;
using SistemaWebRecetas.Models;

namespace SistemaWebRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DbRecetasContext context;
        public RecetaController(DbRecetasContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var receta = context.Recetas.ToList();
            return View(receta);
        }

       

        [HttpGet]
        public IActionResult IndexByAutor(string autor)
        {
            var recetas = (from e in context.Recetas
                           where e.Autor == autor
                           select e).ToList();
            return View("Index", recetas);
        }

        [HttpGet]
        public IActionResult IndexByApellido(string apellido)
        {
            var recetas = (from e in context.Recetas
                           where e.Apellido == apellido
                           select e).ToList();
            return View("Index", recetas);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Receta recetas = new Receta();

            return View("Create", recetas);
        }

        
        [HttpPost]
        public ActionResult Create(Receta recetas)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(recetas);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recetas);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta recetas = TraerUno(id);
            if (recetas == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", recetas);
            }
        }

        private Receta TraerUno(int id)
        {
            return context.Recetas.Find(id);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            Receta recetas = TraerUno(id);
            if (recetas == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", recetas);
            }

        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Receta recetas = TraerUno(id);
            if (recetas == null)
            {
                return NotFound();
            }
            else
            {
                context.Recetas.Remove(recetas);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var recetas = context.Recetas.Find(id);
            if (recetas == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", recetas);
            }
        }

        [ActionName("Edit")]
        [HttpPost]
        public ActionResult EditConfirmed(Receta recetas)
        {

            context.Entry(recetas).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
