using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class People
    {
        public string FullName { get; set; }
        public DateOnly Birthday { get; set; }

        public People(string fullName, DateOnly birthday)
        {
            FullName = fullName;
            Birthday = birthday;
        }
        
        public int Age
        {
            get
            {
                var today = DateOnly.FromDateTime(DateTime.Today);
                int age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }

        public override string ToString()
        {
            return $"{FullName}: {Birthday:dd.MM.yyyy} (Возраст: {Age})";
        }
    }
}
