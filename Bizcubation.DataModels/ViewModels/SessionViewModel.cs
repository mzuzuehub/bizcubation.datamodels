using Bizcubation.DataModels.DTOs;
using System.Collections.Generic;

namespace Bizcubation.DataModels.ViewModels
{
    public class SessionViewModel : SessionDto
    {
        public List<LessonDto> Lessons { get; set; }
        public List<UserAssessmentViewModel> UserAssessments { get; set; }
        public List<ProgramDto> Programs { get; set; }
        public int NumberOfLessons { get; set; }
        public bool isAccessible { get; set; }
    }
}
