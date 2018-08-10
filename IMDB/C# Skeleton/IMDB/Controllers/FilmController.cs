namespace IMDB.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class FilmController : Controller
    {
        private readonly IMDBDbContext dbContext;

        public FilmController(IMDBDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var film = this.dbContext.Films.ToList();
            return View(film);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            // TODO
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Film film)
        {
            // TODO
            this.dbContext.Films.Add(film);
            this.dbContext.SaveChanges();
            return Redirect("/");
           
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int? id)
        {
            var films = dbContext.Films.Find(id);
            return View(films);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Film film)
        {
            // TODO
            this.dbContext.Update(film);
            this.dbContext.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int? id)
        {
            // TODO
            var film = dbContext.Films.Find(id);           
            return View(film);
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Film film)
        {
           
            this.dbContext.Remove(film);
            this.dbContext.SaveChanges();
            return Redirect("/");

        }
    }
}
