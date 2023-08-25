using Bizcubation.DataModels.General;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class LessonDto : CRUDBaseDto
    {
        [Display(Name = "Lession Id")]
        public int LessonId { get; set; }

        [Display(Name = "Lession Title")]
        [Required(ErrorMessage = "Lession Title cannot be blank")]
        public string LessonTitle { get; set; }

        [Display(Name = "Lession body")]
        [Required(ErrorMessage = "Lession body cannot be blank")]
        public string LessonBody { get; set; }

        [Display(Name = "Session Id")]
        [Required(ErrorMessage = "session Id cannot be blank")]
        public int SessionId { get; set; }

        [Display(Name = "Session Name")]
        public string SessionName { get; set; }

        [Display(Name = "Order")]
        public int Order { get; set; }

        [Display(Name = "Is Enabled")]
        public bool IsEnabled { get; set; }

        public List<LessonSectionDto> Sections { get; set; } = new List<LessonSectionDto>();
    }
}
