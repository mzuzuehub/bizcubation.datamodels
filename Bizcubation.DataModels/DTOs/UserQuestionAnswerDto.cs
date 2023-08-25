using Bizcubation.DataModels.General;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class UserQuestionAnswerDto : CRUDBaseDto
    {

        [Display(Name = "User Question Answer Id")]
        [Required(ErrorMessage = "User Question Answer Id cannot be blank")]
        public int UserQuestionAnswerId { get; set; }

        [Display(Name = "Marks")]
        [Required(ErrorMessage = "Marks cannot be blank")]
        public decimal Marks { get; set; }

        [Display(Name = "Has Passed")]
        [Required(ErrorMessage = "Has Passed cannot be blank")]
        public bool HasPassed { get; set; }

        [Display(Name = "User Assessment Id")]
        [Required(ErrorMessage = "User Assessment Id cannot be blank")]
        public int UserAssessmentId { get; set; }

        [Display(Name = "Assessment Answer Id")]
        [Required(ErrorMessage = "Assessment Answer Id cannot be blank")]
        public int AssessmentAnswerId { get; set; }

        [Display(Name = "Session Id")]
        [Required(ErrorMessage = "Session Id cannot be blank")]
        public int SessionId { get; set; }

        [Display(Name = "Lesson Id")]
        [Required(ErrorMessage = "Lessonn Id cannot be blank")]
        public int LessonId { get; set; }

        [Display(Name = "Session Title")]
        public string SessionTitle { get; set; }
    }
}
