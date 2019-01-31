using GDM.HW7.Interfaces;
using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Services
{
    class FileStorage : IStorage
    {
        public string Path { get; set; } 

        public FileStorage(string Path)
        {
            this.Path = Path;
        }
        Buffer Buffer = new Buffer();

        public void AddMessage(LogRecord logRecord)
        {
            Buffer.AddMessageToBuffer(logRecord);
            if (Buffer.GetBuffer().Count == 5)
            {
                for (int i = 0; i < Buffer.GetBuffer().Count; i++)
                {
                    using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.UTF8))
                    {
                        sw.WriteLine(Buffer.GetBuffer().ElementAt(i));
                        sw.Flush();
                    }
                }
            }
        }
    }
}
