using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    public class Topic
    {
        public Topic()
        {
            this.Comments = new List<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        public string Description { get; set; }
        
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Last Updated Date")]
        public DateTime LastUpdatedDate { get; set; }

        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }

        public List<Comment> Comments { get; set; }

        [NotMapped]
        [Display(Name = "Number Comments")]
        public int NumberComments => this.Comments.Count;

        public bool isAuthor(string id)
        {
            return this.Author.UserName == id;
        }
    }
}
