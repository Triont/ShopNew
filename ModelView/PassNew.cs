using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewShopApp.ModelView
{
    public class PassNew
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Password should contains at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]

        public string Pass { get; init; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Pass", ErrorMessage = "Passwords do not match")]
        public string ConfirmPass { get; init; }

        public string token { get; init; }
    }
}
