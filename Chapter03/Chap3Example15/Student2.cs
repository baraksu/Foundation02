using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3Example15
{
    public class Student2
    {
        private string _name;
        private string _idNum;
        private int[] _grades;

        public Student2(string name, string idNum, int[] grades)
        {
            _name = name;
            _idNum = idNum;
            //_grades = grades;
            _grades = new int[ grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                _grades[i] = grades[i];
            }

        }
        public string GetName()
        {
            return _name;
        }
        public string GetIdNum()
        {
            return _idNum;
        }
        public int[] GetGrades()
        {
            //return _grades;
            int[]grades = new int[ _grades.Length ];
            for (int i = 0; i < _grades.Length; i++)
            {
                grades[i] = _grades[i];
            }
            return grades;
        }
        public void SetGrades (int[] grades)
        {
            _grades = new int[grades.Length];
            for (int i = 0; i < _grades.Length; i++)
            {
                _grades[i] = grades[i];

            }
        }
        public double ComputeAverage()
        {
            int sum = 0;
            for (int i = 0; i < _grades.Length; i++)
            {
                sum += _grades[i];
            }
            return (double)sum / _grades.Length;

        }
        public override string ToString()
        {
            string allGrades= "";
            for (int i = 0; i < _grades.Length; i++)
            {
                allGrades += _grades[i] + " ";
            }
            return $"Name:{_name}, Id:{_idNum}, grades:{allGrades} ";

        }

    }
}
