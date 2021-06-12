using OfficeOpenXml;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace CoffeeManagementSystem.Model.Common
{
    public static class ConvertData
    {
        private static readonly string NumberGroup = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator; // VN "."
        private static readonly string NumberDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator; // VN ","

        /// <summary>
        /// ToDecimal.
        /// </summary>
        /// <param name="value">value.</param>
        /// <returns>ToDecimal Return.</returns>
        public static decimal ToDecimal(string value)
        {
            // Kiểu My
            if (NumberGroup == "," && NumberDecimal == ".")
            {
                return decimal.Parse(value);
            }

            // Kiểu Việt Nam
            else
            {
                const string temp = "@";
                value = value.Replace(".", temp);
                value = value.Replace(",", ".");
                value = value.Replace(temp, ",");
                return decimal.Parse(value);
            }
        }

        /// <summary>
        /// ToStr.
        /// </summary>
        /// <param name="pValue">pValue.</param>
        /// <returns>pValue Return.</returns>
        public static string ToStr(decimal pValue)
        {
            string value;

            // kieu My
            if (NumberGroup == "," && NumberDecimal == ".")
            {
                const string temp = "@";

                value = pValue.ToString(CoffeeManagementSystemConfig.NumberFormat);
                value = value.Replace(".", temp);
                value = value.Replace(",", ".");
                value = value.Replace(temp, ",");
                return value;
            }

            // Kiểu Việt Nam
            else
            {
                value = pValue.ToString(CoffeeManagementSystemConfig.NumberFormat);
                return value;
            }
        }

        public static DateTime? ToDateTime(this decimal pNumber)
        {
            if (pNumber > 0)
            {
                return DateTime.ParseExact(pNumber.ToString(CultureInfo.CurrentCulture), CoffeeManagementSystemConfig.DateTimeSqlFormat, CultureInfo.CurrentCulture);
            }

            return null;
        }

        /// <summary>
        /// ToBigInt.
        /// </summary>
        /// <param name="pDateTime">pDateTime.</param>
        /// <returns>pDateTime return.</returns>
        public static decimal ToBigInt(this DateTime pDateTime)
        {
            return Convert.ToDecimal(pDateTime.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat));
        }

        public static decimal ToBigInt(this DateTime? pDateTime)
        {
            return Convert.ToDecimal(pDateTime?.ToString(CoffeeManagementSystemConfig.DateTimeSqlFormat));
        }

        public static decimal ToBigInt(this string pDateDdMmYyyy, int pAddDays = 0)
        {
            return DateTime.TryParseExact(pDateDdMmYyyy, CoffeeManagementSystemConfig.DateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out var oDate) ? oDate.AddDays(pAddDays).ToBigInt() : 0;
        }

        public static DateTime ToDateExp(this long pNumber)
        {
            return pNumber > 0 ? DateTime.ParseExact(pNumber.ToString(), CoffeeManagementSystemConfig.DateExpSqlFormat, CultureInfo.CurrentCulture) : CoffeeManagementSystemConfig.MaxDateExp;
        }

        public static long ToBigIntDateExp(this DateTime pDateTime)
        {
            return Convert.ToInt64(pDateTime.ToString(CoffeeManagementSystemConfig.DateExpSqlFormat));
        }

        public static DateTime AddNow(this DateTime pDateTime)
        {
            DateTime now = DateTime.Now;
            return pDateTime.Date.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddTicks(now.Ticks);
        }

        public static bool IsBetween(this DateTime pDateTimeBetween, DateTime pDateTimeBegin, DateTime pDateTimeEnd)
        {
            return pDateTimeBegin >= pDateTimeBetween && pDateTimeBetween >= pDateTimeEnd;
        }

        public static string GetEnumDescription<TEnum>(this TEnum pItem)
            => pItem.GetType()
               .GetField(pItem.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false)
               .Cast<DescriptionAttribute>().FirstOrDefault()?.Description ?? string.Empty;

        public static TEnum GetEnumFromDescription<TEnum>(string pDescription)
        {
            var type = typeof(TEnum);
            if (!type.IsEnum)
            {
                throw new ArgumentException();
            }

            FieldInfo[] fields = type.GetFields();
            var field = fields
                            .SelectMany(f => f.GetCustomAttributes(
                                typeof(DescriptionAttribute), false), (
                                f, a) => new { Field = f, Att = a }).SingleOrDefault(a => ((DescriptionAttribute)a.Att)
                                                                                          .Description == pDescription);
            return field == null ? default : (TEnum)field.Field.GetRawConstantValue();
        }

        /// <summary>
        /// CalculatorYearStudy.
        /// </summary>
        /// <returns>Return Year Study of student.</returns>
        public static string CalculatorYearStudy()
        {
            var currentYear = DateTime.Now.Year;
            string yearOldStudy = $"{currentYear}-{currentYear + 1}";
            return yearOldStudy;
        }

        /// <summary>
        /// ClearDataOfImportFile.
        /// </summary>
        /// <param name="excelWorksheets">excelWorksheets.</param>
        public static void ClearDataOfImportFile(ExcelWorksheet excelWorksheets)
        {
            for (int i = excelWorksheets.Dimension.Start.Row + 1; i <= excelWorksheets.Dimension.End.Row; i++)
            {
                bool isDeleteRow = true;
                for (int j = excelWorksheets.Dimension.Start.Column; j < excelWorksheets.Dimension.End.Column; j++)
                {
                    if (excelWorksheets.Cells[i, j].Value == null)
                    {
                        isDeleteRow = true;
                        break;
                    }
                }

                if (isDeleteRow)
                {
                    excelWorksheets.DeleteRow(i);
                }
            }
        }

        public static string ConvertUtf8ToString(this string utf8String)
        {
            if (!String.IsNullOrEmpty(utf8String))
            {
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = utf8String.ToLower().Trim().Normalize(NormalizationForm.FormD);
                return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(" ", "");
            }
            else
            {
                return utf8String;
            }
        }

        // Convert DateTime to format "yyyy-MM-dd"
        public static string ConvertToYYYYMMDD(this DateTime dateTimeConvert)
        {
            if (!String.IsNullOrEmpty(dateTimeConvert.ToString()))
            {
                return dateTimeConvert.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture.DateTimeFormat);
            }
            else
            {
                return String.Empty;
            }
        }

        public static DateTime? ConvertStringToDateTime(this string stringDateTimeConvert)
        {
            if (stringDateTimeConvert != null)
            {
                return Convert.ToDateTime(stringDateTimeConvert);
            }
            else
            {
                return null;
            }
        }
    }
}
