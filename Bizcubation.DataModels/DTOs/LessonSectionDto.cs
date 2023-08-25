using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class LessonSectionDto
    {
        [Display(Name = "Lesson Section Id")]
        public int LessonSectionId { get; set; }

        [Display(Name = "Lesson Id")]
        public int LessonId { get; set; }

        [Display(Name = "Section Content")]
        public string SectionContent { get; set; }

        [Display(Name = "Section Order")]
        public int SectionOrder { get; set; }
    }
}
