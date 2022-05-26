/*
!!!!!!!!!!!!!!
У коді я добавив нижнє підкреслення для змінних в класах, замінив деякі init на set де це було необхідно 
та переписав заповнення зубчастого масиву
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab1Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //1:
            WriteLine("1:\n");
            Student student = new Student();
            WriteLine(student.ToShortString());

            //2:
            WriteLine("2:\n");
            WriteLine(student[Education.Master]);
            WriteLine(student[Education.Bachelor]);
            WriteLine(student[Education.SecondEducation]);

            //3:
            WriteLine("\n\n3:\n");
            student = new Student() { Person = new Person("Petro", "Savak", new DateTime(2001, 11, 3)), Educate = Education.SecondEducation, Group = 308, Exams = new Exam[] { new Exam("English", 4, new DateTime(2022, 5, 28)), new Exam(), new Exam("Chemistry", 5, new DateTime(2022, 5, 29)) } };
            WriteLine(student.ToString());

            //4:
            WriteLine("4:\n");
            Exam[] exams = new Exam[] { new Exam("Psychology", 5, new DateTime(2022, 6, 1)), new Exam("Biology", 4, new DateTime(2022, 6, 2)) };
            student.AddExams(exams);
            WriteLine(student.ToString());

            //5:
            WriteLine("\n\n\n\n5:\n");
            WriteLine("Enter n rows and n nolumns. Split this numbers symbols , ; |");
            string str = Console.ReadLine();

            string[] numbers = str.Split(new[] { ',', ';', '|' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = Convert.ToInt32(numbers[0]);
            int columns = Convert.ToInt32(numbers[1]);


            Exam[] oneDimensionalArray = new Exam[rows * columns];
            for (int i = 0; i < rows * columns; i++) oneDimensionalArray[i] = new Exam();

            Exam[][] twoDimensionalArray = new Exam[rows][];
            for (int i = 0; i < rows; i++)
            {
                twoDimensionalArray[i] = new Exam[columns];
                for (int j = 0; j < columns; j++)
                {
                    twoDimensionalArray[i][j] = new Exam();
                }
            }

            int start, end;
            
            int jrows = 0;//кількість рядків в зубчастому масиві
            int number = 0;//кількість заповнених елементів масиву 
            int sum = rows*columns;//кількість елементів яку потрібно додати в масив
            
            for (int i = 0; ((double)(i * i) / 2 + i) < sum; i++)
                jrows = i+1;
           
            Exam[][] jaggedMasiv = new Exam[jrows][];

            for (int i = 0; i<jrows; i++)
            {
                if(sum-number>=i+1)
                    jaggedMasiv[i] = new Exam[i+1];
                else
                    jaggedMasiv[i] = new Exam[sum-number];
                for (int j = 0; j < i+1 && number<sum; j++)
                {
                    jaggedMasiv[i][j] = new Exam();
                    number++;
                    Write("[]");//Для перевірки побудованого масиву я вивожу його схему де [] -його елемент
                }
                WriteLine();
            }

            start = Environment.TickCount;
            for (int i = 0; i <= jaggedMasiv.Length - 1; i++)
            {

                for (int j = 0; j < jaggedMasiv[i].Length; j++)
                {
                    jaggedMasiv[i][j].Grade = 5;
                    Write("()");
                }
                WriteLine();
            }

            end = Environment.TickCount;
            WriteLine($"Execution time for one jagged masiv: {end - start} ms");
            

            start = Environment.TickCount;
            for (int i = 0; i < oneDimensionalArray.Length; i++) oneDimensionalArray[i].Grade = 3;
            end = Environment.TickCount;
            WriteLine($"Execution time for one dimension masiv: {end - start} ms");

            start = Environment.TickCount;
            for (int i = 0; i < twoDimensionalArray.Length; i++)
            {
                for (int j = 0; j < twoDimensionalArray[i].Length; j++)
                {
                    twoDimensionalArray[i][j].Grade = 3;
                }
            }
            end = Environment.TickCount;
            WriteLine($"Execution time for two dimension masiv: {end - start} ms");

        }
    }
}
