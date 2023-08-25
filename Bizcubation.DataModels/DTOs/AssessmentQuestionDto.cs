using Bizcubation.DataModels.General;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class AssessmentQuestionDto : CRUDBaseDto
    {
        [Display(Name = "Assessment Question Id")]
        public int AssessmentQuestionId { get; set; }

        [Display(Name = "Assessment Question Id")]
        [Required(ErrorMessage = "Question cannot be blank")]
        public string Question { get; set; }

        [Display(Name = "Asnwer")]
        public string Answer { get; set; }

        [Display(Name = "Is Multiplechoice")]
        [Required(ErrorMessage = "Is Multiplechoice cannot be blank")]
        public bool IsMultipleChoice { get; set; }

        [Display(Name = "Is Is Open Ended")]
        [Required(ErrorMessage = "Is Is Open Ended cannot be blank")]
        public bool IsOpenEnded { get; set; }

        [Display(Name = "Multiple Choices")]
        public string[] MultipleChoices { get; set; }

        [Display(Name = "Pass Mark Threshold")]
        public decimal? PassMarkThreshold { get; set; }

        [Display(Name = "Session Id")]
        [Required(ErrorMessage = "Session Id")]
        public int SessionId { get; set; }

        [Display(Name = "Lesson Id")]
        [Required(ErrorMessage = "Lesson Id")]
        public int LessonId { get; set; }

        [Display(Name = "Session Title")]
        public string SessionTitle { get; set; }

        [Display(Name = "Lesson Title")]
        public string LessonTitle { get; set; }
    }
}
