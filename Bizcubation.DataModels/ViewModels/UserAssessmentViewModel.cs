using Bizcubation.DataModels.DTOs;
using System.Collections.Generic;

namespace Bizcubation.DataModels.ViewModels
{
    public class UserAssessmentViewModel : UserAssessmentDto
    {
        public List<UserQuestionAnswerDto> UserQuestionAnswers { get; set; } = new List<UserQuestionAnswerDto>();
    }
}
