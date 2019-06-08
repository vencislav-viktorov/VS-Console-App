﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Last Updated Date")]
        public DateTime LastUpdatedDate { get; set; }

        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }

        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }

        public bool isAuthor(string username)
        {
            return this.Author.UserName == username;
        }
    }
}
