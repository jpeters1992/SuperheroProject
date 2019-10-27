using SUPERHEROES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SUPERHEROES.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext context;

        //CONSTRUCTOR
        public SuperheroesController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Superheroes
        public ActionResult Index()
        {
            return View(context.Superheroes.ToList());
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superHero = context.Superheroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            SuperHero newSuperHero = new SuperHero();
            return View(newSuperHero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                context.Superheroes.Add(superHero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = context.Superheroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                SuperHero editedSuperHero = context.Superheroes.Find(id);
                editedSuperHero.Name = superHero.Name;
                editedSuperHero.AlterEgo = superHero.AlterEgo;
                editedSuperHero.PrimaryAbility = superHero.PrimaryAbility;
                editedSuperHero.SecondaryAbility = superHero.SecondaryAbility;
                editedSuperHero.CatchPhrase = superHero.CatchPhrase;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero superHero = context.Superheroes.Where(s => s.Id == id).SingleOrDefault();
            return View(superHero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superHero)
        {
            try
            {
                context.Superheroes.Remove(context.Superheroes.Find(id));
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
