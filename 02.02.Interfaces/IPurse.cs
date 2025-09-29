using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Interfaces
{
    internal interface IPurse
    {
        int Summ { get; set; }
        void AddMoney (int amount);
        int DecMoney (int amount);
    }
}
