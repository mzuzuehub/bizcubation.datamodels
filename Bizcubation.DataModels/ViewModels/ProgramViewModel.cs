using Bizcubation.DataModels.DTOs;
using System.Collections.Generic;

namespace Bizcubation.DataModels.ViewModels
{
    public class ProgramViewModel : ProgramDto
    {
        public List<SessionDto> Sessions { get; set; }
        public int NumberOfSessions { get; set; }
        public int NumberOfLessons { get; set; }
        public bool isAccessible { get; set; }
    }
}
