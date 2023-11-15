using System;
using System.IO;
using System.Linq;

namespace Logger_home_work_2._5
{
    public class FileService
    {
        private readonly string logDirectory;

        public FileService(string logDirectory)
        {
            this.logDirectory = logDirectory;
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        public void WriteToFile(string fileName, string content)
        {
            string filePath = Path.Combine(logDirectory, fileName);
            File.WriteAllText(filePath, content);
            CleanUpOldFiles();
        }

        private void CleanUpOldFiles()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(logDirectory);
            FileInfo[] files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();

            while (files.Length > 3)
            {
                File.Delete(files[0].FullName);
                files = directoryInfo.GetFiles().OrderBy(f => f.CreationTime).ToArray();
            }
        }
    }
}
