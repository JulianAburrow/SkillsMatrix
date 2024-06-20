using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.DisplayModels
{
    public class UserDisplayModel
    {
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "{0} is required")]
        [Display(Name = "Status")]
        public int StatusId { get; set; }

        public List<UserSkillDisplayModel> UserSkill { get; set; }
    }
}
