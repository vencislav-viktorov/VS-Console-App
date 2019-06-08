using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Forum.Controllers
{
    public class CommentController : Controller
    {
        private readonly ForumDbContext context;

        public CommentController(ForumDbContext context)
        {
            this.context = context;
        }

        [Authorize]
        [HttpGet]
        [Route("/Topic/Details/{id}/Comment/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        [Route("/Topic/Details/{TopicId}/Comment/Create")]
        public IActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                string authorId = context
                    .Users
                    .Where(u => u.UserName == this.User.Identity.Name)
                    .FirstOrDefault()
                    .Id;

                if (authorId == null)
                {
                    return Redirect($"/Topic/Details/{comment.TopicId}");
                }

                comment.AuthorId = authorId;

                comment.CreatedDate = DateTime.Now;
                comment.LastUpdatedDate = DateTime.Now;

                context.Comments.Add(comment);

                Topic topic = context
                    .Topics
                    .Find(comment.TopicId);

                topic.LastUpdatedDate = DateTime.Now;

                context.SaveChanges();

                return Redirect($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        [HttpGet]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(int? topicId, int? id)
        {
            if (id == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            Comment comment = context
                .Comments
                .Include(c => c.Author)
                .Include(c => c.Topic)
                .ThenInclude(t => t.Author)
                .Where(c => c.CommentId == id)
                .FirstOrDefault();

            if (comment == null)
            {
                return RedirectPermanent($"/Topic/Details/{topicId}");
            }

            if (comment.isAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(comment);
        }

        [Authorize]
        [HttpPost]
        [Route("/Topic/Details/{TopicId}/Comment/Edit/{id}")]
        public IActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                var commentFromDb = context
                    .Comments
                    .Where(c => c.CommentId == comment.CommentId)
                    .FirstOrDefault();

                if (commentFromDb == null)
                {
                    return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
                }

                commentFromDb.Description = comment.Description;
                commentFromDb.LastUpdatedDate = DateTime.Now;

                Topic topic = context
                    .Topics
                    .Find(comment.TopicId);

                if (topic == null)
                {
                    return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
                }

                topic.LastUpdatedDate = DateTime.Now;

                context.SaveChanges();

                return RedirectPermanent($"/Topic/Details/{comment.TopicId}");
            }

            return View(comment);
        }

        [HttpGet]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int? topicId, int? id)
        {
            if (id == null)
            {
                return Redirect($"/Topic/Details/{topicId}");
            }

            var comment = context
                .Comments
                .Include(c => c.Author)
                .Where(c => c.CommentId == id)
                .FirstOrDefault();

            if (comment == null)
            {
                return Redirect($"/Topic/Details/{topicId}");
            }

            if (comment.isAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            return View(comment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var comment = context
                .Comments
                .Find(id);

            if (comment != null)
            {
                Topic topic = context
                    .Topics
                    .Find(comment.TopicId);

                topic.LastUpdatedDate = DateTime.Now;

                context.Comments.Remove(comment);
                context.SaveChanges();
            }

            return Redirect($"/Topic/Details/{comment.TopicId}");
        }

        //[HttpPost]
        //[Route("/Topic/Details/{TopicId}/Comment/Delete/{id}")]
        //public IActionResult Delete(int topicId, int id)
        //{
        //    if (id == null)
        //    {
        //        return Redirect($"/Topic/Details/{topicId}");
        //    }

        //    var comment = context
        //        .Comments
        //        .Find(id);

        //    if (comment == null)
        //    {
        //        return Redirect($"/Topic/Details/{topicId}");
        //    }

        //    context.Comments.Remove(comment);

        //    if (topicId == null)
        //    {
        //        return Redirect($"/Topic/Details/{topicId}");
        //    }

        //    Topic topic = context
        //        .Topics
        //        .Find(comment.TopicId);

        //    if (topic == null)
        //    {
        //        return Redirect($"/Topic/Details/{topicId}");
        //    }

        //    topic.LastUpdatedDate = DateTime.Now;

        //    context.SaveChanges();

        //    return Redirect($"/Topic/Details/{topicId}");
        //}


    }
}