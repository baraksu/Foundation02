using Xunit;
using Bagrut2023Q02;

namespace Bagrut2023
{
    public class Bagrut2023Q2Tests
    {
        
        [Fact]
        public void Q2_MinningNum_MissMiddle3rdNumber_15()
        {
            int[] arr2 = { 5, 10, 20, 25 };
            Assert.Equal(15, Bagrut2023Q02Main.MinningNum(arr2));
        }
        [Fact]
        public void Q2_MinningNum_MissMiddleSecondNumber_10()
        {
            int[] arr2 = { 5, 15, 20, 25 };
            Assert.Equal(10, Bagrut2023Q02Main.MinningNum(arr2));
        }
        [Fact]
        public void Q2_MinningNum_MissOneBeforEndNumber_10()
        {
            int[] arr2 = { 5,10, 15,  25 };
            Assert.Equal(20, Bagrut2023Q02Main.MinningNum(arr2));
        }
    }
}