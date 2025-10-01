using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankI
{
    interface IPurse
    {
        int Summ { get; set; }
        void AddMoney(int amount);
        int DecMoney(int amount);
    }
}
