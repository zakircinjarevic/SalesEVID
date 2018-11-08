using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesEVID;
using System.IO;
using Main;
namespace SalesEVID
{
    class Log
    {
        public static void Debug(string message)
        {
            LogToFile("DEBUG :  " + message);
        }
        public static void Info(string message)
        {
            LogToFile("INFO  :  " + message);
        }
        public static void Error(string message)
        {
            LogToFile("ERROR :  " + message);
        }
        public static void Warn(string message)
        {
            LogToFile("WARN  :  " + message);
        }
        private static void LogToFile(string message)
        {
            if (!Directory.Exists(AppPaths.AppLogPath))
                Directory.CreateDirectory(AppPaths.AppLogPath);

            var path = String.Format(@"{0}\AppLog_{1}.txt", AppPaths.AppLogPath, DateTime.Today.ToString("yyyyMM"));

            //rename the file if it exists
            var fi = new FileInfo(path);
            if (fi.Exists && fi.Length >= 10485760) //10485760 = 10MB
            {
                try
                {
                    File.Copy(path, AppPaths.AppLogPath + "\\" + FileNameIndex(Path.GetFileNameWithoutExtension(path)) + ".txt");
                    fi.Delete();
                }
                catch { }
            }

            //if not
            try
            {
                if (!File.Exists(path))
                {
                    using (var sw = File.CreateText(path))
                    {
                        sw.WriteLine("######### SalesEVIDService - Log File Started @ {0} #########", DateTime.Now);
                        sw.Close();
                        sw.Dispose();
                    }
                }

                using (var sw = File.AppendText(path))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy  H:mm:ss  :  ") + message);
                    sw.Close();
                    sw.Dispose();
                }
            }
            catch
            {
                //file is open somewhere
            }
        }

        private static string FileNameIndex(string fileName)
        {
            var newFileName = fileName;
            var i = 1;
            var di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "\\Log");
            foreach (var file in di.GetFiles())
            {
                while (Path.GetFileNameWithoutExtension(file.Name) == newFileName)
                {
                    newFileName = fileName + i;
                    i++;
                }
            }
            return newFileName;
        }
    }
}
