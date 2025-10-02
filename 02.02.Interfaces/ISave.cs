using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal interface ISave : IPurse
    {
        bool IsLocked { get; }
        void Lock();
        void Unlock();
    }
}
