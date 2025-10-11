using System;
using System.IO;

namespace _02._05_EventsWPF
{
    public class FileLogger : ILogger
    {
        private readonly string _logFilePath;

        public FileLogger(string logFileName = "application.log")
        {

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _logFilePath = Path.Combine(documentsPath, logFileName);
        }

        public void Log(string message)
        {
            WriteToFile($"[INFO] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
        }

        public void LogError(string message)
        {
            WriteToFile($"[ERROR] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
        }

        public void LogWarning(string message)
        {
            WriteToFile($"[WARNING] {DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
        }

        private void WriteToFile(string logMessage)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_logFilePath, true))
                {
                    writer.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Не удалось записать в лог-файл: {ex.Message}");
            }
        }
    }
}