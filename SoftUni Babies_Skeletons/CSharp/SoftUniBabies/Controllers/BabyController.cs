namespace SoftUniBabies.Controllers
{
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class BabyController : Controller
    {
        private readonly BabyDbContext dbContext;

        public BabyController(BabyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //TODO
            var babies = this.dbContext.Babies.ToList();
            return View(babies);
        }

        [HttpGet]
        [Route("/create")]
        public IActionResult Create()
        {
            //TODO

            return View();
        }

        [HttpPost]
        [Route("/create")]
        public IActionResult Create(Baby baby)
        {
            this.dbContext.Babies.Add(baby);
            this.dbContext.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            //TODO
            var baby = this.dbContext.Babies.Find(id);
            return View(baby);
        }

        [HttpPost]
        [Route("/edit/{id}")]
        public IActionResult Edit(Baby baby)
        {
            //TODO
            this.dbContext.Update(baby);
            this.dbContext.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            //TODO
            var babyDelete = this.dbContext.Babies.Find(id);
            return View(babyDelete);
        }

        [HttpPost]
        [Route("/delete/{id}")]
        public IActionResult Delete(Baby baby)
        {
            //TODO
            this.dbContext.Babies.Remove(baby);
            this.dbContext.SaveChanges();
            return Redirect("/");
        }
    }
}
