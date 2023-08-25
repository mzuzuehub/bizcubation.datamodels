using Bizcubation.DataModels.General;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class ProgramDto : CRUDBaseDto
    {
        [Display(Name = "Program Id")]
        public int ProgramId { get; set; }

        [Display(Name = "Program Name")]
        [Required(ErrorMessage = "Program Name cannot be blank")]
        public string ProgramName { get; set; }

        [Display(Name = "Program Description")]
        public string ProgramDescription { get; set; }

        [Display(Name = "Order")]
        public int Order { get; set; }
    }
}
