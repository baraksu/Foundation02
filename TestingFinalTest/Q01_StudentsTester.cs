using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest2023;
using Xunit;

namespace TestingFinalTest
{
    
    public class Q01_StudentsTester

    {
        [Fact(Skip="e")]
        public void Quesion01_elad_Test()
        {
            var arr = new[] { 15, 10, 30, -7 };

            //var result01= Quesion01_elad.IsZigzag(arr);

           // Assert.Equal<bool>(true,result01);

            arr = new[] { 15, 10, 30,40 };

            var result02 = Quesion01_e.IsZigzag(arr);

            Assert.Equal<bool>(false, result02);
        }

        [Fact(Skip = "d")]
        public void Quesion01_D_Test()
        {
            int[] arrr = new int[2];
            int[]arrr1 = new int[2];

            var mat = new[,] { { 1, 2 }, { 3, 4 } };

            foreach (var i in mat)
            {
                int b = i;
            }
            Assert.Equal(3, arrr1.Length);

            var arr = new[] { -8, 10, 2, 100 };

            var result01= Quesion01_e.IsZigzag(arr);

            Assert.Equal<bool>(true,result01);
            
        }
    }
}
