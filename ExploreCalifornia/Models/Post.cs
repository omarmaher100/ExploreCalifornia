using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        [Display(Name = "Post Title")]
        [Required]
        [StringLength(150 ,MinimumLength = 15 , ErrorMessage = "Title must be more thans 15 and less than 150")]
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        [MinLength(110 ,ErrorMessage ="Post must be at least 110 char")]
        public string Body { get; set; }
        public DateTime Posted { get; set; }

    }
}
