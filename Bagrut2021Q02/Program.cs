using System.Security.Cryptography.X509Certificates;

namespace Bagrut2021Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Subject
    {
        private string subName;

        public string GetSubName()
        {
            return this.subName;
        }
        public void SetSubName(string subName)
        {
            this.subName = subName;
        }

        private int grade;

        public int GetGrade()
        {
            return this.grade;
        }
        public void SetGrade(int grade)
        {
            this.grade = grade;
        }


    }

    public class ReportCard
    {
        private string stuName;

        private Subject[] subArray;


        public string GetStuName()
        {
            return this.stuName;
        }
        public void SetStuName(string studName)
        {
            this.stuName = studName;
        }

        public ReportCard(string name, int num)
        {
            this.stuName = name;
            this.subArray = new Subject[num];
        }

        public double Avarege()
        {
            double sum = 0;
            for (int i = 0; i < subArray.Length; i++)
            {
                sum += subArray[i].GetGrade();
            }
            return sum / subArray.Length;
        }

        public bool IsExecllent()
        {

            bool has100 = false;
            bool hasAllAboveUp54 = true;

            for (int i = 0; i < subArray.Length; i++)
            {
                if (subArray[i].GetGrade() == 100)
                {
                    has100 = true;
                }

                if (subArray[i].GetGrade() <= 54)
                {
                    hasAllAboveUp54 = false;
                    return false;
                }
            }

            return has100 && Avarege() >= 85;
        }
    }

}
