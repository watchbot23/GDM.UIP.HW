using GDM.HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDM.HW7.Interfaces
{
    public interface IStorage
    {
        void AddMessage(LogRecord logreCord);
    }
}
