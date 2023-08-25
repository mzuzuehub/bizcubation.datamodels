namespace Bizcubation.DataModels.DTOs
{
    public class ExamResultsSummaryByStudentByMonthDto : ExamResultsSummaryByMonthDto
    {
        public string StudentName { get; set; }
        public string StudentEmailAddress { get; set; }
    }
}
