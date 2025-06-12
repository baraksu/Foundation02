using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2024Q03
{
    public class Bicycle
    {
		private double price;

		public double GetPrice()
		{
			return this.price;
		}
		public void SetPrice(double price)
		{
			this.price = price;
		}
		private string type;

		public string GetType()
		{
			return this.type;
		}
		public void SetType(string type)
		{
			this.type = type;
		}
		private string company;

		public string GetCompany()
		{
			return this.company;
		}
		public void SetCompany(string company)
		{
			this.company = company;
		}

        public Bicycle(double price, string type, string company)
        {
            this.price = price;
            this.type = type;
            this.company = company;
        }

        public bool IsCheaper(Bicycle bicycle)
        {
			return this.price < bicycle.GetPrice();
        }
	}
}
