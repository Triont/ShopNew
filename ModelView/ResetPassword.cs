using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewShopApp.ModelView
{
    public class ResetPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
