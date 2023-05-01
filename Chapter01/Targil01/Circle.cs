using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Targil01
{
    public class Circle
    {
        // please add comment
        private int _radius;

      

      
        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
            }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int GetRadius()
        {
            return _radius;
        }
        public void SetRadius(int radius)
        {
            this._radius = radius;
        }
        public Circle()
        {

        }
        public Circle(int radius, string color)
        {
            //_radius = radius;
            //_color = color;

            Radius = radius;
            Color = color;

            this.Radius = radius;
            this._radius = radius;


        }
            public double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);

            }
        public static double GetPI()
        {
            return Math.PI;

        }
        public void ToString()
        {
            Console.WriteLine(Radius);
            Console.WriteLine(Color);
        }




    }
}

