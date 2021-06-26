using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoffeeManagementSystem.Model.Request
{
    public class LoginModel
    {
        /// <summary>
     /// Gets or sets UserName.
     /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [Required]
        public string Email { get; set; }
    }
}
