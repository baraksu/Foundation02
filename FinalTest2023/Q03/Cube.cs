using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2023.Q03
{
    public class Cube
    {
        private int size;
        private string color;

        public int GetSize()
        {
            return size;
        }

        public void SetSize(int size)
        {
            this.size =size;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public Cube(int size, string color)
        {
            this.size = size;
            this.color = color;
        }
    }
}
