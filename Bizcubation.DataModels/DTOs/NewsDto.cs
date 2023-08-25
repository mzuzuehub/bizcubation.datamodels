using System;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class NewsDto
    {
        [Display(Name = "News Id")]
        public int NewsId { get; set; }

        [Required]
        [Display(Name = "Heading")]
        public string Heading { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Date Posted")]
        public DateTime DatePosted { get; set; }

        [Display(Name = "Is Visible")]
        public bool? IsVisible { get; set; }
    }
}
