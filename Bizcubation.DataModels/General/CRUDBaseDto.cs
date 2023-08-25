using System;
using System.ComponentModel.DataAnnotations;

namespace Bizcubation.DataModels.General
{
    public class CRUDBaseDto
    {
        [Display(Name = "Date Created")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy HH:mm:ss}")]
        [Required(ErrorMessage = "Date Created cannot be blank")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Created By")]
        [Required(ErrorMessage = "Created By cannot be blank")]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Date Modified")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy HH:mm:ss}")]
        public DateTime? DateModified { get; set; }
    }
}
