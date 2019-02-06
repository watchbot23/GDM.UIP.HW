using GDM.HW7.Interfaces;
using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Services
{
    public class Logger : ILogger
    {
        private List<IStorage> Storages;

        public LogLevel LogLevel { get; set; }

        public Logger(List<IStorage> storages)
        {
            Storages = storages;
        }

        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            AddMessage(message, LogLevel.Info);
            Console.ResetColor();
        }
        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            AddMessage(message, LogLevel.Warn);
            Console.ResetColor();
        }
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            AddMessage(message, LogLevel.Error);
            Console.ResetColor();
        }
        public void Debug(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            AddMessage(message, LogLevel.Debug);
            Console.ResetColor();
        }
        public void Fatal(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            AddMessage(message, LogLevel.Fatal);
            Console.ResetColor();
        }

        public void AddMessage(string message, LogLevel logLevel)
        {
            if (logLevel < LogLevel)
            {
                return;
            }
            LogRecord logRecord = new LogRecord()
            {
                Message = message,
                DateTime = DateTime.Now,
                LogLevel = logLevel
            };
            foreach (var storage in Storages)
            {
                storage.AddMessage(logRecord);
            }
        }
    }
}
