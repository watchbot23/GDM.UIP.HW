using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Services
{
    public class Buffer
    {
        List<String> Buff = new List<string>();

        public void AddMessageToBuffer(LogRecord logRecord)
        {
            if (Buff.Count != 5)
            {
                Buff.Add(logRecord.ToString());
            }
            else
            {
                Buff.RemoveRange(0, Buff.Count);
                Buff.Add(logRecord.ToString());
            }
        }

        public List<String> GetBuffer()
        {
            return Buff;
        }
    }
}
