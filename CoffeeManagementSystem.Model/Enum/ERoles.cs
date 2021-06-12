using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CoffeeManagementSystem.Model.Enum
{
    public enum ERoles
    {
        /// <summary>
        /// Admin.
        /// </summary>
        [Description("Admin System")]
        Admin = 1,

        /// <summary>
        /// User.
        /// </summary>
        [Description("User System")]
        User = 2,
    }
}
