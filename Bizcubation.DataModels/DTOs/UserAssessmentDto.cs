using Bizcubation.DataModels.General;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class UserAssessmentDto : CRUDBaseDto
    {

        [Display(Name = "User Assessment Id")]
        public int UserAssessmentId { get; set; }

        [Display(Name = "Overall Mark")]
        [Required(ErrorMessage = "Overall Mark cannot be blank")]
        public decimal OverallMark { get; set; }

        [Display(Name = "Hass Passed")]
        [Required(ErrorMessage = "Hass Passed cannot be blank")]
        public bool HasPassed { get; set; }

        [Display(Name = "Session Id")]
        [Required(ErrorMessage = "Session Id cannot be blank")]
        public int SessionId { get; set; }

        [Display(Name = "Lesson Id")]
        [Required(ErrorMessage = "Lessonn Id cannot be blank")]
        public int LessonId { get; set; }
    }
}
