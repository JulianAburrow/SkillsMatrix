using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DisplayModels
{
    public class SkillDisplayModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Skill Name")]
        public string SkillName { get; set; }
    }
}
