using Bizcubation.DataModels.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bizcubation.DataModels.ViewModels
{
    public class AssessmentQuestionViewModel :AssessmentQuestionDto
    {
        public List<SessionDto> Sessions { get; set; }
    }
}
