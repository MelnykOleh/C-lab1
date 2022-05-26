using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1Csharp
{
    class Student
    {
        private Person _person;
        private Education _education;
        private int _group;
        private Exam[] _exams;

        public Student(Person person, Education education, int group)
        {
            Person = person;
            Educate = education;
            Group = group;
        }

        public Student() : this(person: new Person(), education: Education.Bachelor, group: 101)
        {
            Exams = new Exam[] { new Exam(), new Exam("Physics", 5, new DateTime(2022, 5, 27)) };
        }

        public Person Person
        {
            get
            {
                return _person;
            }

            init
            {
                _person = value;
            }
        }

        public Education Educate
        {
            get
            {
                return _education;
            }

            init
            {
                _education = value;
            }
        }

        public int Group
        {
            get
            {
                return _group;
            }

            init
            {
                _group = value;
            }
        }

        public Exam[] Exams
        {
            get
            {
                return _exams;
            }

            set
            {
                _exams = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                double averageGrade = 0;
                if (Exams == null || Exams.Length == 0) return 0;

                foreach (Exam exam in Exams)
                {
                    averageGrade += exam.Grade;
                }
                return averageGrade / Exams.Length;
            }
        }

        public bool this[Education educate]
        {
            get
            {
                return educate == Educate;
            }
        }

        public void AddExams(Exam[] newExams)
        {
            if (Exams == null || newExams.Length == 0) return;

            Exam[] allExams = new Exam[Exams.Length + newExams.Length];
            
            int i = 0, j = 0;
            while (j < Exams.Length)
            {
                allExams[i++] = Exams[j];
                j++;
            }

            j = 0;
            while (j < newExams.Length)
            {
                allExams[i++] = newExams[j];
                j++;
            }

            Exams = allExams;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            foreach (Exam ex in Exams)
            {
                text.Append(ex);
            }

            return $"Info about student:\t{Person}\nEducation: {Educate}\tGroup: {Group}\nList exams:\t{text}\n";
        }

        public string ToShortString()
        {
            return $"Info about student:\t{Person}\nEducation: {Educate}\tGroup: {Group}\tAverage grade: {AverageGrade}\n";
        }
    }
}
