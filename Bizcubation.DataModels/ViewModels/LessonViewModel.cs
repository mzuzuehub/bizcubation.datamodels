using Bizcubation.DataModels.DTOs;
using System.Collections.Generic;

namespace Bizcubation.DataModels.ViewModels
{
    public class LessonViewModel: LessonDto
    {
        public List<SessionDto> Sessions { get; set; }
    }
}
