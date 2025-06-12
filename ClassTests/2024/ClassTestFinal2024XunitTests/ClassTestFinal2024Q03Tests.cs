using FinalTest2024Q03;

namespace ClassTestFinal2024XunitTests
{
    public class ClassTestFinal2024Q03Tests
    {
        [Fact]
        public void Empty2Bicycles_Add3Bicycles_LastAddFalse()
        {
            AllBicycles allBicycles = new AllBicycles(2);
            Bicycle bicycle1 = new Bicycle(100, "Mountain", "Company1");
            Bicycle bicycle2 = new Bicycle(200, "Mountain", "Company2");
            Bicycle bicycle3 = new Bicycle(300, "Mountain", "Company3");

            bool added;
            added = allBicycles.AddBicycle(bicycle1);
            Assert.True(added);
            
            added = allBicycles.AddBicycle(bicycle2);
            Assert.True(added);

            added =  allBicycles.AddBicycle(bicycle3);
            Assert.False(added);


        }
        [Fact]
        public void Bicycles2from10_PrintMountainType_Print2Prices()
        {
            AllBicycles allBicycles = new AllBicycles(2);
            Bicycle bicycle1 = new Bicycle(100, "Mountain", "Company1");
            Bicycle bicycle2 = new Bicycle(200, "Mountain", "Company2");
            Bicycle bicycle3 = new Bicycle(300, "Mountain", "Company3");

           
            allBicycles.AddBicycle(bicycle1);
            allBicycles.AddBicycle(bicycle2);
            
            allBicycles.Print(bicycle3);

           

           


        }
    }
}