
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.Models
{
    public class Category
    {
        public Category()
        {
            this.Topics = new List<Topic>();
        }
        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

        public List<Topic> Topics { get; set; }

        [NotMapped]
        public int NumberTopics => Topics.Count;

        public bool isAuthor(string username)
        {
            return this.Author.UserName == username;
        }
    }
}
