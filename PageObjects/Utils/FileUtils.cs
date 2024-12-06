using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Utils
{
    public static class FileUtils
    {
        public static string GetDownloadPath() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

        public static string GetFullDownloadedFilePath(string downloadPath, string fileName) => Path.Combine(downloadPath, fileName);

        public static string GetProjectDirectory() => Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        public static string GetFilePathToBeUploaded(string projectDirectory, string folderName, string fileName) => Path.Combine(projectDirectory, folderName, fileName);
    }
}
