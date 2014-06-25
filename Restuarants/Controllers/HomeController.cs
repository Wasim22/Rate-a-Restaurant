using Restuarants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restuarants.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            List<Restuarant> Restuarants = db.Restuarants.ToList();
            return View(Restuarants);
        }

        //---------- READ

        public ActionResult About(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Restuarant restuarant = db.Restuarants.Where(r => r.Id == id).FirstOrDefault();
            return View(restuarant);
        }

        //---------- CREATE

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string cuisine, string img, int rating)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Restuarant restuarant = new Restuarant();
            restuarant.Name = name;
            restuarant.Cuisine = cuisine;
            restuarant.Img = img;
            restuarant.Rating = rating;
            db.Restuarants.Add(restuarant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //---------- UPDATE


        public ActionResult Update(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Restuarant restuarant = db.Restuarants.Where(r => r.Id == id).FirstOrDefault();
            return View(restuarant);
        }

        [HttpPost]
        public ActionResult Update(int id, string name, string cuisine, string img, int rating)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Restuarant restuarant = db.Restuarants.Where(r => r.Id == id).FirstOrDefault();
            restuarant.Name = name;
            restuarant.Cuisine = cuisine;
            restuarant.Img = img;
            restuarant.Rating = rating;
            db.SaveChanges();
            return RedirectToAction("About/"+id);
        }

        //---------------- DELETE

        public ActionResult Delete(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Restuarant restuarant = db.Restuarants.Where(r => r.Id == id).FirstOrDefault();
            db.Restuarants.Remove(restuarant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }







    }
}