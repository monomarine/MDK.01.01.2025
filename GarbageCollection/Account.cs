using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    internal class Account
    {
        private static int _count = 0;
        private Student _student;
        private Group _group;
        private string _login;

        public static int Count { get { return _count; } set { _count= value; } }
        public int Id { get; set; }
        public Student Student { get { return _student; } set { _student = value; } }
        public Group Group { get { return _group; } set { _group = value; } }
        public string Login { get { return _login; } set { _login = value; } }

        public Account()
        {
            Id = ++Count;
            Student = new Student();
            Group = new Group();
            Login = "заглушков.зз1100";
        }
        public override string ToString()
        {
            return $"Id {Id}\nСтудент {Student.Name}\nГруппа {Group.Name}\nКуратор группы {Group.Curator}\nЛогин {Login}\n";
        }
    }
    internal class Student
    {
        public string Name { get; set; }
        public Student(string name = "Заглушков З. З.")
        {
            Name = name;
        }

    }
    internal class Group
    {
        public string Name { get; set; }
        public string Curator { get; set; }
        public Group(string name = "1з1", string curator = "Неизвестнов Н. Н.")
        {
            Name = name;
            Curator = curator;
        }
    }
}
