using FinalTest2023.Q01.students;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinalTest2023.Xunit.UnitTests
{
    [TestClass]
    public class Q01_StudentsTester

    {
        [Ignore]
        public void Quesion01_elad_Test()
        {
            var arr = new[] { 15, 10, 30, -7 };

            //var result01= Quesion01_elad.IsZigzag(arr);

           // Assert.AreEqual<bool>(true,result01);

            arr = new[] { 15, 10, 30,40 };

            var result02 = Quesion01_e.IsZigzag(arr);

            Assert.AreEqual<bool>(false, result02);
        }

        [Ignore]
        public void Quesion01_D_Test()
        {
            int[] arrr = new int[2];
            int[]arrr1 = new int[2];

            var mat = new[,] { { 1, 2 }, { 3, 4 } };

            foreach (var i in mat)
            {
                int b = i;
            }
            Assert.AreEqual(3, arrr1.Length);

            var arr = new[] { -8, 10, 2, 100 };

            var result01= Quesion01_e.IsZigzag(arr);

            Assert.AreEqual<bool>(true,result01);
            
        }
    }
}
