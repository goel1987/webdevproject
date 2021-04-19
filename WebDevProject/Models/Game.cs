using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevProject.Models
{
    public class Game
    {
        // EF Core will configure the database to generate this value 
        public int GameId { get; set; }
        [Required(ErrorMessage = "Please enter a name.")] public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a year.")] [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")] public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        public string RatingId { get; set; }
        public Rating Rating { get; set; }

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();



    }
}
