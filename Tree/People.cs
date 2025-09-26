using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class People
    {
        public string FIO { get; set; }
        public DateTime BirthDate { get; set; }

        public People(string fio, DateTime birthDate)
        {
            FIO = fio;
            BirthDate = birthDate;
        }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public override string ToString()
        {
            return $"{FIO} ({BirthDate:dd.MM.yyyy})";
        }
    }
}
