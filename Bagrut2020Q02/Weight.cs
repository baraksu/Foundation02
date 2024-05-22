using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut2020Q02
{
    public class Weight
    {
        private int kilo;

        public int GetKilo()
        {
            return this.kilo;
        }
        public void SetKilo(int kilo)
        {
            this.kilo = kilo;
        }

        private int gram;

        public int GetGram()
        {
            return this.gram;
        }
        public void SetGram(int gram)
        {
            this.gram = gram;
        }

        public Weight()
        {
            this.kilo = 0;
            this.gram = 0;
            this.gram = 0;
        }

        public Weight(int kilo, int gram)
        {
            this.kilo = kilo;
            this.gram = gram;
        }

        public Weight(int totalGram)
        {
			this.kilo = totalGram / 1000;
			this.gram = totalGram % 1000;
        }

        public void Add02(Weight other)
        {
            int gram = this.gram + other.GetGram();
            this.gram += gram % 1000;
            this.kilo += other.kilo + gram / 1000;

        }

        public void Add(Weight w)
        {
            this.kilo += w.GetKilo();
            this.gram += w.GetGram();
            if (this.gram >= 1000)
            {
                this.kilo++;
                this.gram -= 1000;
            }


        }

        public void Add03(Weight other)
        {
            if (this.gram + other.gram >= 1000)
            {
                this.kilo += other.kilo + 1;
                this.gram = this.gram + other.gram - 1000;
                //this.gram = (this.gram + other.gram) % 1000;
            }
            else
            {
                this.kilo += other.kilo;
                this.gram += other.gram;
            }
        }

        public bool Less(Weight other)
        {
            //return this.kilo < other.GetKilo() || (this.kilo == other.GetKilo() && this.gram < other.GetGram());
            
            if (this.kilo < other.kilo)
            {
                return true;
            }
            if (this.kilo == other.kilo)
            {
                if (this.gram < other.gram)
                {
                    return true;
                }
            }
            return false;

        }

	}
}
