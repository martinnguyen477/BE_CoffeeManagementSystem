
using CoffeeManagementSystem.Model.Common;
using Microsoft.Extensions.Configuration;
using System;

namespace CoffeeManagementSystem.API.Functions
{
    public class HelperConstantsModel
    {
        private readonly IConfiguration _configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="HelperConstantsModel"/> class.
        /// HelperConstantsModel.
        /// </summary>
        /// <param name="config">config.</param>
        public HelperConstantsModel(IConfiguration config)
        {
            _configuration = config;
        }

        /// <summary>
        /// LoadConfig.
        /// </summary>
        /// <param name="configuration">configuration. Hàm load config cho project.</param>
        public static void LoadConfig(IConfiguration configuration)
        {
            var section = configuration.GetSection("AppConfig");
            var emailConfig = configuration.GetSection("MailSettings");
            var cloudDinary = configuration.GetSection("CloudinanySettings");
            var selectConneectionPostgress = configuration.GetSection("AppConfig_Postgre").Value;

            CoffeeManagementSystemConfig.ConnectionStringPostgres = selectConneectionPostgress;
            CoffeeManagementSystemConfig.ConnectionString = section.GetValue<string>("DefaultConnection");
            CoffeeManagementSystemConfig.AppName = section.GetValue<string>("AppName");
            CoffeeManagementSystemConfig.NumberFormat = section.GetValue<string>("NumberFormat");
            CoffeeManagementSystemConfig.DateFormat = section.GetValue<string>("DateFormat");
            CoffeeManagementSystemConfig.TimeFormat = section.GetValue<string>("TimeFormat");
            CoffeeManagementSystemConfig.SpecialCharacters = section.GetValue<string>("SpecialCharacters");
            CoffeeManagementSystemConfig.NumberPatternFormat = section.GetValue<string>("NumberPatternFormat");
            CoffeeManagementSystemConfig.DateTimeFormat = section.GetValue<string>("DateTimeFormat");
            CoffeeManagementSystemConfig.DateTimeSqlFormat = section.GetValue<string>("DateTimeSQLFormat");
            CoffeeManagementSystemConfig.DateExpSqlFormat = section.GetValue<string>("DateExpSQLFormat");
            CoffeeManagementSystemConfig.EmailFormat = section.GetValue<string>("EmailFormat");
            CoffeeManagementSystemConfig.SerialMmDdFormat = section.GetValue<string>("SerialMmDdFormat");
            CoffeeManagementSystemConfig.MaxDateExp = Convert.ToDateTime(section.GetValue<string>("MaxDateExp"));
            CoffeeManagementSystemConfig.SerialMmFormat = section.GetValue<string>("SerialMmFormat");
            CoffeeManagementSystemConfig.DefaultPassword = section.GetValue<string>("DefaultPassword");
            CoffeeManagementSystemConfig.NumberGeneratePassword = section.GetValue<int>("NumberGeneratePassword");
            CoffeeManagementSystemConfig.EmailTemplateUrl = section.GetValue<string>("EmailTemplateUrl");
            CoffeeManagementSystemConfig.UrlDefaultOfPrefect = section.GetValue<string>("UrlDefaultOfPrefect");
            CoffeeManagementSystemConfig.UrlDefaultOfStudent = section.GetValue<string>("UrlDefaultOfStudent");
            CoffeeManagementSystemConfig.UrlDefaultOfUser = section.GetValue<string>("UrlDefaultOfUser");
            CoffeeManagementSystemConfig.NotedImportExampoint = section.GetValue<string>("NotedImportExampoint");

            CoffeeManagementSystemConfig.EMail = emailConfig.GetValue<string>("EMail");
            CoffeeManagementSystemConfig.DisplayName = emailConfig.GetValue<string>("DisplayName");
            CoffeeManagementSystemConfig.Password = emailConfig.GetValue<string>("Password");
            CoffeeManagementSystemConfig.Host = emailConfig.GetValue<string>("Host");
            CoffeeManagementSystemConfig.Port = emailConfig.GetValue<int>("Port");
            CoffeeManagementSystemConfig.ResetPassUserTitle = emailConfig.GetValue<string>("ResetPassUserTitle");

            CoffeeManagementSystemConfig.CloudName = cloudDinary.GetValue<string>("CloudName");
            CoffeeManagementSystemConfig.APIKey = cloudDinary.GetValue<string>("APIKey");
            CoffeeManagementSystemConfig.APISecret = cloudDinary.GetValue<string>("APISecret");
        }

        private string GetAppSettings(string pTagKey)
        {
            string host = _configuration.GetSection("AppSettings").GetSection(pTagKey).Value;
            return host ?? "";
        }

        /// <summary>
        /// GetAppSettingsSecret.
        /// </summary>
        /// <returns>Return string of Secret of JWT.</returns>
        public string GetAppSettingsSecret()
        {
            return GetAppSettings("Secret");
        }

        /// <summary>
        /// GetAppSettingsExpiresDate.
        /// </summary>
        /// <returns>Return string for AppSetting ExpiresDate.</returns>
        public string GetAppSettingsExpiresDate()
        {
            return GetAppSettings("ExpiresDate");
        }
    }
}
