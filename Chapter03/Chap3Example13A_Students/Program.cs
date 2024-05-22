using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Example13A_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array of int
            int[] numbers = new int[30];
            numbers[0] = 1;

            Student[] students = new Student[30];
            students[0] = new Student(1, "Barak");
            string studentName = students[0].GetName();

            //print student Names
            Print01(students);
            Print02(students);
        }

        private static void Print02(Student[] students)
        {
            foreach (Student student in students)
            {
                {
                    Console.WriteLine(student.GetName());
                }

            }
        }

        private static void Print01(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].GetName());
            }
        }

        
    }
    class Student
    {
        private string name;
        private int id;

        public Student(int id, string name)
        {
            this.name = name;
            this.id = id;
        }
        public string GetName()
        {
            return name;
        }
        public int GetId()
        {
            return id;
        }
    }
}
