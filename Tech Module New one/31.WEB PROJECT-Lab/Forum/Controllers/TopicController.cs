using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Forum.Controllers
{
    public class TopicController : Controller
    {
        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
        {
            this.context = context;
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = this.context
                .Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Include(t => t.Comments)
                .ThenInclude(c => c.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            var categoryNames = context
                .Categories
                .Select(c => c.Name)
                .ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                topic.CreatedDate = DateTime.Now;
                topic.LastUpdatedDate = DateTime.Now;

                var userId = this.context
                    .Users
                    .Where(u => u.UserName == this.User.Identity.Name)
                    .FirstOrDefault()
                    .Id;
                
                topic.AuthorId = userId;

                if (!context.Categories.Any(c => c.Name == categoryName))
                {
                    return View(topic);
                }

                int categoryId = context
                    .Categories
                    .FirstOrDefault(c => c.Name == categoryName)
                    .Id;

                topic.CategoryId = categoryId;

                this.context.Topics.Add(topic);
                this.context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = this.context
                .Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (topic.isAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(topic);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var topic = this.context
                .Topics
                .Include(t => t.Author)
                .Where(t => t.Id == id)
                .FirstOrDefault();

            if (topic == null || topic.Author.UserName != User.Identity.Name)
            {
                return RedirectToAction("Index", "Home");
            }

            this.context.Topics.Remove(topic);
            this.context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var topic = this.context
                .Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Where(t => t.Id == id)
                .FirstOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (topic.isAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            var categoryNames = context
                .Categories
                .Select(c => c.Name)
                .ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View(topic);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                var dbTopic = this.context
                    .Topics
                    .Include(t => t.Author)
                    .Where(t => t.Id == topic.Id)
                    .FirstOrDefault();

                if (dbTopic == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                dbTopic.Title = topic.Title;
                dbTopic.Description = topic.Description;

                int categoryId = context
                    .Categories
                    .FirstOrDefault(c => c.Name == categoryName)
                    .Id;

                dbTopic.CategoryId = categoryId;

                dbTopic.LastUpdatedDate = DateTime.Now;

                this.context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }
    }
}