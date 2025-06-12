using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2024Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllBicycles allBicycles = new AllBicycles(100);
            Bicycle bicycle1 = new Bicycle(100, "Mountain", "Company1");
            Bicycle bicycle2 = new Bicycle(200, "Mountain", "Company2");
            Bicycle bicycle3 = new Bicycle(300, "Mountain", "Company3");


            allBicycles.AddBicycle(bicycle1);
            allBicycles.AddBicycle(bicycle2);

            allBicycles.Print(bicycle3);

            Console.ReadKey();

        }
    }

}
