using System.IO;

namespace CoffeeManagementSystem.Model.Common
{
    public class HelperFunction
    {
        /// <summary>
        /// ReturnUrlFilePathExport. Hàm hỗ trợ export file excel.
        /// </summary>
        /// <param name="fileNameTemplate">fileNameTemplate.</param>
        /// <param name="fileNameExport">fileNameExport.</param>
        /// <param name="folderExport">folderExport.</param>
        /// <param name="folderTemplate">folderTemplate.</param>
        /// <returns>Return Url for path Export.</returns>
        public static string ReturnUrlFilePathExport(string fileNameTemplate, string fileNameExport, string folderExport, string folderTemplate)
        {
            if (!Directory.Exists(folderExport))
            {
                Directory.CreateDirectory(folderExport);
            }

            string filePathExport = Path.Combine(folderExport, fileNameExport);
            string filePathTemplate = Path.Combine(folderTemplate, fileNameTemplate);

            // Get data from file teamplate
            FileStream fileTemplate = new FileStream(filePathTemplate, FileMode.Open);
            using (FileStream fs = File.Create(filePathExport))
            {
                fileTemplate.CopyTo(fs);
                fs.Flush();
            }

            return filePathExport;
        }
    }
}
