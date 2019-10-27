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
            return View();
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
            return View();
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
