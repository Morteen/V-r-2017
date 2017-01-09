using MVCRoller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoller.Controllers
{
    public class KulturController : Controller
    {
        private KulturContext KulturDb = new KulturContext();
        // GET: Kultur
        [Authorize]
        public ActionResult Index()
        {
            //View laget
            var kultur = KulturDb.KulturListe.ToList();
            return View(kultur);
        }

        // GET: Kultur/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            //View laget
            Kultur kultur = KulturDb.KulturListe.Find(id);
            if (kultur == null)
                return HttpNotFound();

            return View(kultur);
        }

        // GET: Kultur/Create
        [Authorize(Roles = "super")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kultur/Create
        [HttpPost]
        [Authorize(Roles = "super")]
        public ActionResult Create(Kultur kultur)
        {
            //View laget
            try
            {
                if (ModelState.IsValid)
                {
                    KulturDb.KulturListe.Add(kultur);
                    KulturDb.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(kultur);
            }
            catch
            {
                return View();
            }
        }

        // GET: Kultur/Edit/5
        [Authorize(Roles = "super")]
        public ActionResult Edit(int id)
        {
            Kultur kultur = KulturDb.KulturListe.Find(id);
            return View(kultur);
        }

        // POST: Kultur/Edit/5
        [Authorize(Roles = "super")]
        [HttpPost]
        public ActionResult Edit(Kultur kultur)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    KulturDb.Entry(kultur).State = System.Data.Entity.EntityState.Modified;
                    KulturDb.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(kultur);
            }
            catch
            {
                return View();
            }
        }

        // GET: Kultur/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            Kultur kultur = KulturDb.KulturListe.Find(id);
            return View(kultur);
        }

        // POST: Kultur/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                Kultur kultur = new Kultur();
                if (ModelState.IsValid)
                {
                    kultur = KulturDb.KulturListe.Find(id);
                    if (kultur == null)
                        return HttpNotFound();
                    KulturDb.KulturListe.Remove(kultur);
                    KulturDb.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(kultur);
            }
            catch
            {
                return View();
            }
        }
    }
}
