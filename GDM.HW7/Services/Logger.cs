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
            AddMessage(message, LogLevel.Info);
        }
        public void Warn(string message)
        {
            AddMessage(message, LogLevel.Warn);
        }
        public void Error(string message)
        {
            AddMessage(message, LogLevel.Error);
        }
        public void Debug(string message)
        {
            AddMessage(message, LogLevel.Debug);
        }
        public void Fatal(string message)
        {
            AddMessage(message, LogLevel.Fatal);
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
