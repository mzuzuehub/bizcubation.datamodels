using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bizcubation.DataModels.DTOs
{
    public class AdditionalContentDto
    {
        [Display(Name = "Content Id")]
        public int ContentId { get; set; }

        [Required]
        [Display(Name = "Url")]
        public string Url { get; set; }

        [Required]
        [Display(Name = "LessonId")]
        public int LessonId { get; set; }

        [Display(Name = "Is Visible")]
        public bool? IsVisible { get; set; }

        [Required]
        [Display(Name = "Url Description")]
        public string UrlDescription { get; set; }

    }
}
