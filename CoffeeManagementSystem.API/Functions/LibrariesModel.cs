// <copyright file="LibrariesModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.Request;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace CoffeeManagementSystem.API.Functions
{
    public static class LibrariesModel
    {
        /// <summary>
        /// SetUserAction.
        /// </summary>
        /// <param name="pObj">pObj.</param>
        /// <returns>Return SetUserAction.</returns>
        public static RepositoryModel SetUserAction(object pObj)
        {
            int id = CookieViewModel.Id;
            var result = new RepositoryModel();
            if (id != 0)
            {
                SetUser(pObj);
                result.SetSuccess(null, "Cookies đã tồn tại");
            }
            else
            {
                result.SetNoCookie("Bạn đang truy cập web bằng thao tác của Dev hoặc Tester");
            }

            return result;
        }

        /// <summary>
        /// SetUser.
        /// </summary>
        /// <param name="pObj">pObj.</param>
        public static void SetUser(object pObj)
        {
            int cookiesId = CookieViewModel.Id;
            var pros = pObj.GetType().GetProperties();
            var id = pros.SingleOrDefault(p => p.Name == "ID");
            if (id != null)
            {
                bool isInsert = (long)id.GetValue(pObj) == 0;
                if (isInsert)
                {
                    var createBy = pros.SingleOrDefault(p => p.Name == "CreateBy");
                    if (createBy != null)
                    {
                        createBy.SetValue(pObj, cookiesId);
                    }

                    var updateBy = pros.SingleOrDefault(p => p.Name == "UpdateBy");
                    if (updateBy != null)
                    {
                        updateBy.SetValue(pObj, cookiesId);
                    }
                }
                else
                {
                    var updateBy = pros.SingleOrDefault(p => p.Name == "UpdateBy");
                    if (updateBy != null)
                    {
                        updateBy.SetValue(pObj, cookiesId);
                    }
                }

                var property = pros.FirstOrDefault(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(List<>));
                if (property != null)
                {
                    object propValue = property.GetValue(pObj, null);
                    if (propValue is System.Collections.IList elems)
                    {
                        foreach (var item in elems)
                        {
                            SetUser(item);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// ObjectToString.
        /// </summary>
        /// <typeparam name="T">T.</typeparam>
        /// <param name="data">data.</param>
        /// <returns>Return string ObjectToString.</returns>
        public static string ObjectToString<T>(T data)
        {
            if (data != null)
            {
                return JsonConvert.SerializeObject(data);
            }

            return "";
        }

        /// <summary>
        /// StringToObject.
        /// </summary>
        /// <typeparam name="T">T.</typeparam>
        /// <param name="values">values.</param>
        /// <returns>Return StringToObject.</returns>
        public static T StringToObject<T>(string values) where T : class
        {
            if (!string.IsNullOrEmpty(values) && values != "{}")
            {
                return JsonConvert.DeserializeObject<T>(values);
            }

            return null;
        }

        /// <summary>
        /// EncodePassword.
        /// </summary>
        /// <param name="password">password.</param>
        /// <returns>Return Encode Pass word.</returns>
        public static string EncodePassword(string password)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5Provider.ComputeHash(new UTF8Encoding().GetBytes(password));

            foreach (var t in bytes)
            {
                hash.Append(t.ToString("x2"));
            }

            return hash.ToString();
        }

        /// <summary>
        /// SetCookie.
        /// </summary>
        public static void SetCookie()
        {
            var identity = (ClaimsPrincipal)Thread.CurrentPrincipal;
            var cookies = identity.Claims.ToList();
            CookieViewModel.Id = Convert.ToInt32(GetCookie(cookies, "ID"));
            CookieViewModel.UserName = GetCookie(cookies, "UserName");
            CookieViewModel.Role = GetCookie(cookies, "Role");
            CookieViewModel.Email = GetCookie(cookies, "Email");
        }

        private static string GetCookie(List<Claim> claim, string pKey)
        {
            var cookie = claim.SingleOrDefault(p => p.Type == pKey);
            return cookie?.Value;
        }

        /// <summary>
        /// ClearCookie.
        /// </summary>
        public static void ClearCookie()
        {
            CookieViewModel.Id = 0;
            CookieViewModel.UserName = null;
            CookieViewModel.Role = string.Empty;
            CookieViewModel.Email = string.Empty;
        }

        /// <summary>
        /// GenerateToken.
        /// </summary>
        /// <param name="secret">secret.</param>
        /// <param name="expiresDate">expiresDate.</param>
        /// <param name="value">value.</param>
        /// <returns>Return Token.</returns>
        public static string GenerateToken(string secret, int expiresDate, string value)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, value) // user.Id.ToString()
                }),
                Expires = DateTime.Today.AddDays(expiresDate),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }
    }
}
