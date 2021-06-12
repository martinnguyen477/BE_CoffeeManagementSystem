using CoffeeManagementSystem.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CoffeeManagementSystem.Model.Common
{
    public static class Generator
    {
        private static readonly Random Rand = new Random();

        /// <summary>
        /// GenerateCode4Number.
        /// </summary>
        /// <param name="pContext">The context value.</param>
        /// <param name="pKey">The key value.</param>
        /// <param name="pFullTypeModel">The pFullTypeModel value.</param>
        /// <returns>GenerateCode4Number value.</returns>
        public static string GenerateCode4Number(DbContext pContext, string pKey, string pFullTypeModel)
        {
            return GenerateCode(pContext, pKey, pFullTypeModel, 4);
        }

        public static string GenerateCode6Number(DbContext pContext, string pKey, string pFullTypeModel)
        {
            return GenerateCode(pContext, pKey, pFullTypeModel, 6);
        }

        public static string GenerateCode9Number(DbContext pContext, string pKey, string pFullTypeModel)
        {
            return GenerateCode(pContext, pKey, pFullTypeModel, 9);
        }

        public static string GenerateCodeTracker(string controllerName, string actionName, string pKey)
        {
            return GenerateCodeTracking(controllerName, actionName, pKey, 9);
        }

        private static string GenerateCode(DbContext pContext, string pKey, string pFullTypeModel, int pNumberPart)
        {
            if (string.IsNullOrEmpty(pKey))
            {
                return string.Empty;
            }

            pKey = pKey.ToUpper();
            SerialGenerator serialItem = pContext.Set<SerialGenerator>().AsNoTracking()
                .SingleOrDefault(p => p.SerialPart == pKey
                    && p.TypeName == pFullTypeModel);

            if (serialItem == null)
            {
                serialItem = new SerialGenerator()
                {
                    TypeName = pFullTypeModel,
                    SerialPart = pKey,
                    NumericPart = 1,
                };

                // pContext.Set<SerialGenerator>().Add(serialTable);
                pContext.Entry(serialItem).State = EntityState.Added;
            }
            else
            {
                serialItem.NumericPart++;
                pContext.Entry(serialItem).State = EntityState.Modified;
            }

            return serialItem.SerialPart + serialItem.NumericPart.ToString().PadLeft(pNumberPart, '0');
        }

        private static string GenerateCodeTracking(string controllerName, string actionName, string pKey, int pNumberPart)
        {
            if (string.IsNullOrEmpty(pKey))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(controllerName))
            {
                return string.Empty;
            }

            if (string.IsNullOrEmpty(actionName))
            {
                return string.Empty;
            }

            pKey = pKey.ToUpper();
            controllerName = controllerName.ToUpper();
            actionName = actionName.ToUpper();

            return pKey + "." + controllerName + "." + actionName.PadLeft(pNumberPart, '0');
        }

        public static string GeneratePassword(int length)
        {
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string number = "1234567890";
            const string special = "!@#$%^&*_-=+";

            // Get cryptographically random sequence of bytes
            var bytes = new byte[length];
            new RNGCryptoServiceProvider().GetBytes(bytes);

            // Build up a string using random bytes and character classes
            var res = new StringBuilder();
            foreach (byte b in bytes)
            {
                // Randomly select a character class for each byte
                if (Rand.Next(4) == 0)
                {
                    res.Append(lower[b % lower.Count()]);
                }
                else if (Rand.Next(4) == 1)
                {
                    res.Append(upper[b % upper.Count()]);
                }
                else if (Rand.Next(4) == 2)
                {
                    res.Append(number[b % number.Count()]);
                }
                else if (Rand.Next(4) == 3)
                {
                    res.Append(special[b % special.Count()]);
                }
            }

            return res.ToString();
        }
    }
}

