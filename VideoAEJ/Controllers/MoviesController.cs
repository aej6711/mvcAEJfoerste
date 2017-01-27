using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoAEJ.Models;


namespace VideoAEJ.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
      
        {
            var movie = new movie() { Name = "ET" };
            //var movie = new Movie() { Name = "ET" };

            //return View(movie);
            //return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index","Home", new { page=1, sortBy="name"});
         
        }
    }
}