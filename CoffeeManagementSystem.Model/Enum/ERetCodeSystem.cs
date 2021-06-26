using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagementSystem.Model.Enum
{
    public enum ERetCodeSystem
    {/// <summary>
     /// Successfull
     /// </summary>
        Successfull = 1,

        /// <summary>
        /// BadRequest.
        /// </summary>
        BadRequest = 2,

        /// <summary>
        /// SystemError.
        /// </summary>
        SystemError = 3,

        /// <summary>
        /// LoginSuccess.
        /// </summary>
        LoginSuccess = 4,

        /// <summary>
        /// LoginError.
        /// </summary>
        LoginError = 5,

        /// <summary>
        /// ExitAccount.
        /// </summary>
        ExitAccount = 6,

        /// <summary>
        /// ErrorCookie.
        /// </summary>
        ErrorCookie = 7,

        /// <summary>
        /// PasswordNotSame.
        /// </summary>
        PasswordNotSame = 8,

        /// <summary>
        /// NoExitData.
        /// </summary>
        NoExitData = 9,

        /// <summary>
        /// ConfictData.
        /// </summary>
        ConfictData = 10
    }
}
