using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Targil01
{
    public class Weight
    {
        private int _kilo;

        public int Kilo
        {
            get { return _kilo; }
            set { _kilo = value; }
        }

        private int _gram;

        public int Gram
        {
            get { return _gram; }
            set { _gram = value; }
        }


        public Weight()
        {
            Kilo = 0;
            Gram = 0;

        }

        public Weight(int kilo, int gram)
        {
            Kilo = kilo;
            Gram = gram;

        }

        public Weight(int totalGram)
        {
            Gram = totalGram % 1000;

            Kilo = totalGram / 1000;



        }


    }
}
