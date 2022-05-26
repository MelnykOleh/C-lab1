using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Csharp
{
    class Exam
    {
        private string _subject;
        private int _grade;
        private DateTime _date;

        public Exam(string subject, int grade, DateTime date)
        {
            Subject = subject;
            Grade = grade;
            Date = date;
        }

        public Exam() : this(subject: "Mathematics", grade: 4, date: new DateTime(2022, 5, 26)) 
        { }

        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                _subject = value;
            }
        }

        public int Grade
        {
            get
            {
                return _grade;
            }

            set
            {
                _grade = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public override string ToString()
        {
            return $"\nSubject: {Subject}\tGrade: {Grade} \tDate exam: {Date}\n";
        }

    }
}
