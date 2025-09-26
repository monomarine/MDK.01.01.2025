using System;

namespace Tree
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

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

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} (Родился: {BirthDate:dd.MM.yyyy}, Возраст: {Age} лет)";
        }
    }
}