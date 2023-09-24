using Bizcubation.DataModels.General;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.DTOs
{
    public class SessionDto: CRUDBaseDto
    {

        [Display(Name = "Session Id")]
        public int SessionId { get; set; }

        [Display(Name = "Session Name")]
        [Required(ErrorMessage = "Session Name cannot be blank")]
        public string SessionName { get; set; }

        [Display(Name = "Program Id")]
        [Required(ErrorMessage = "Program Id cannot be blank")]
        public int ProgramId { get; set; }

        [Display(Name = "Program Name")]
        public string ProgramName { get; set; }

        [Display(Name = "Session DEscription")]
        public string SessionDescription { get; set; }

        [Display(Name = "Order")]
        public int Order { get; set; }
    }
}
