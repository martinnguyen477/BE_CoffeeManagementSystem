using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagementSystem.Model.Response
{
    public class LoginResponse
    {
        /// <summary>
        /// Gets or sets for UserName.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets for Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets for Token.
        /// </summary>
        public string Token { get; set; }
    }
}
