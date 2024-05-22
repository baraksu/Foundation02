
using Bagrut2019Q01Net8;

namespace Bagrut2019Q01Mstest
{
    [TestClass]
    public class Bagrut2019Q01MstestTests
    {
        [TestMethod]
        public void Extract_With2String_Return2()
        {
            string[] arr = new string [3];
            arr[0] = "ab";
            arr[1] = "cd";
            arr[2] = "efd";

            int count =  Bagrut2019Q01Net8Program.Exact(arr, 2);
            Assert.AreEqual( 2, count);
        }
        [TestMethod]
        public void Extract_With3String_Return1()
        {
            string[] arr = new string[3];
            arr[0] = "ab";
            arr[1] = "cd";
            arr[2] = "efd";

            int count = Bagrut2019Q01Net8Program.Exact(arr, 3);
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void Extract_With4String_Return0()
        {
            string[] arr = new string[3];
            arr[0] = "ab";
            arr[1] = "cd";
            arr[2] = "efd";

            int count = Bagrut2019Q01Net8Program.Exact(arr, 4);
            Assert.AreEqual(0, count);
        }
    }
}