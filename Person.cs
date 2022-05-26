using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Csharp
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _birthday;

        public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public Person() : this(name: "Oleh", surname: "Melnyk", birthday: new DateTime(2001, 8, 27))
        { }

        public string Name
        {
            get
            {
                return _name;
            }

            init
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            init
            {
                _surname = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }

        public int Year
        {
            get
            {
                return Birthday.Year;
            }

            set
            {

                Birthday = new DateTime(Birthday.Year + value, Birthday.Month, Birthday.Day);
            }
        }

        public override string ToString()
        {
            return $"Name:{Name}\tSurname: {Surname}\tBirthday: {Birthday}\n";
        }

        public string ToShortString()
        {
            return $"Name: {Name}\tSurname: {Surname}\n";
        }
    }
}
