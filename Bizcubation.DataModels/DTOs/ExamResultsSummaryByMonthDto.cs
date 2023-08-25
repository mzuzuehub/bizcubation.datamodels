namespace Bizcubation.DataModels.DTOs
{
    public class ExamResultsSummaryByMonthDto
    {
        public string MonthName { get; set; }
        public int Pass { get; set; }
        public int Failed { get; set; }
        public int NotAttempted { get; set; }
        public int Period { get; set; }
    }
}
