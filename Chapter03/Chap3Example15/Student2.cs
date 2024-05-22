using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Example15
{
    public class Student2
    {
        private string name;
        private string idNum;
        private int[] grades;

        public Student2(string name, string idNum, int[] grades)
        {
            this.name = name;
            this.idNum = idNum;
            //grades = grades;
            this.grades = new int[ grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                this.grades[i] = grades[i];
            }

        }
        public string GetName()
        {
            return name;
        }
        public string GetIdNum()
        {
            return idNum;
        }
        public int[] GetGrades()
        {
            //return grades;
            int[]grades = new int[ this.grades.Length ];
            for (int i = 0; i < this.grades.Length; i++)
            {
                grades[i] = this.grades[i];
            }
            return grades;
        }
        public void SetGrades (int[] grades)
        {
            this.grades = new int[grades.Length];
            for (int i = 0; i < this.grades.Length; i++)
            {
                this.grades[i] = grades[i];

            }
        }
        public double ComputeAverage()
        {
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return (double)sum / grades.Length;

        }
        public override string ToString()
        {
            string allGrades= "";
            for (int i = 0; i < grades.Length; i++)
            {
                allGrades += grades[i] + " ";
            }
            return $"Name:{name}, Id:{idNum}, grades:{allGrades} ";

        }

    }
}
