using System;

namespace FinalTest2024Q03
{
    public class AllBicycles
    {
		private int top;

		public int GetTop()
		{
			return this.top;
		}
		public void SetTop(int top)
		{
			this.top = top;
		}
		private Bicycle[] bicycles;

        public AllBicycles(int top)
        {
            this.top = top;
            this.bicycles = new Bicycle[top];
        }

        public bool AddBicycle(Bicycle bicycle)
        {
            if (top > 0)
            {
                top--;
                bicycles[top] = bicycle;
                return true;
            }

            return false;
        }

        public void Print(Bicycle bic)
        {
            //for (int i = this.bicycles.Length-1;i >= top ; i--)
            for (int i = top; i < this.bicycles.Length; i++)
            {
                if (bicycles[i].GetType() == bic.GetType() &&
                    bicycles[i].IsCheaper(bic))
                {
                    Console.WriteLine(bicycles[i].GetPrice());
                }
            }
        }
	}
}