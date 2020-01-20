using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }

        private string _Key;
        public string Key
        {
            get
            {
                if (_Key == null)
                    _Key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");

                return _Key;
            }
            set
            {
                _Key = value;
            }
        }

        [Display(Name = "Post Title")]
        [Required]
        [StringLength(150 ,MinimumLength = 15 , ErrorMessage = "Title must be more thans 15 and less than 150")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Required]
        [MinLength(110 ,ErrorMessage ="Post must be at least 110 char")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public DateTime Posted { get; set; }

    }
}
