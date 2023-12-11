using System;
using System.IO;

namespace ExampleSQLApp.error
{
    internal class WriteError
    {
        public static void LogError(string className, string message)
        {
            string logFilePath = "error_log.txt";

            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
            }

            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine($"{DateTime.Now}: Class: {className}: {message}");
            }
        }
    }
}
