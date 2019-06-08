using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Forum.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ForumDbContext context;

        public CategoryController(ForumDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Create(Category category)
        {
            string authorId = context
                .Users
                .Where(u => u.UserName == this.User.Identity.Name)
                .First()
                .Id;

            category.AuthorId = authorId;

            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();

                //return RedirectToAction("Index", "Home");
                return RedirectToAction("Create", "Topic");
            }

            return View(category);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var category = context
                .Categories
                .Include(c => c.Author)
                .Include(c => c.Topics)
                .ThenInclude(t => t.Author)
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var categories = context
                .Categories
                .Include(c => c.Topics)
                .ToList();
            
            ViewData["Categories"] = categories;

            return View(category);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var category = context
                .Categories
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (category.isAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(category);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                var dbCategory = context
                    .Categories
                    .Where(t => t.Id == category.Id)
                    .FirstOrDefault();

                if (dbCategory == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                dbCategory.Name = category.Name;

                context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(category);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var category = context
                .Categories
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (category.isAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(category);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var category = context
                .Categories
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }

            return RedirectPermanent("/");
        }
    }
}