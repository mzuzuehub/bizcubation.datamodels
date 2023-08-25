using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Bizcubation.DataModels.DTOs
{
    public class FunFactDto
    {
        [Display(Name = "Fun Fact Id")]
        public int FunFactId { get; set; }

        [Required]
        [Display(Name = "Heading")]
        public string Heading { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [Display(Name = "Is Visible")]
        public bool? IsVisible { get; set; }
    }
}
