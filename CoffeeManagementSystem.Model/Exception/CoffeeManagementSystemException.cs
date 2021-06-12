using CoffeeManagementSystem.Model.Common;
using System;

namespace CoffeeManagementSystem.Model.Exception
{
    public class CoffeeManagementSystemException : SystemException
    {/// <summary>
     /// Initializes a new instance of the <see cref="QuanLyThieuNhiException"/> class.
     /// QuanLyThieuNhiException.
     /// </summary>
     /// <param name="message">message.</param>
        public CoffeeManagementSystemException(string message) : base("CoffeeManagementSystem: " + message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuanLyThieuNhiException"/> class.
        /// QuanLyThieuNhiException.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="innerException">innerException.</param>
        public CoffeeManagementSystemException(string message, SystemException innerException) : base(CoffeeManagementSystemConfig.AppName + ": " + message, innerException)
        {
        }
    }
}
