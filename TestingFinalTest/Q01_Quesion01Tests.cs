using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest2023;
using Xunit;

namespace TestingFinalTest
{
    
    public class Q01_Quesion01Tests

    {
        [Fact]
        public void Quesion01_Null_ReturnTrue()
        {
            int[] arr = null;
            
            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result02);
        }
        [Fact]
        public void Quesion01_OneItem_ReturnTrue()
        {
            int[] arr = { 5 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result02);
        }
        [Fact]
        public void Quesion01_TwoItemsEquals_ReturnFalse()
        {
            int[] arr = { 5,5 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(false, result02);
        }
        [Fact]
        public void Quesion01_TwoItemsNotEquals_ReturnTrue()
        {
            int[] arr = { 5, 6 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result02);

            arr = new[] { 6, 5 };
            
            
            var result03 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result03);
        }
        [Fact]
        public void Quesion01_ThreeItemsUpDown_ReturnTrue()
        {
            int[] arr = { 5, 6, 4 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result02);

            arr = new[] { 5,6,7 };


            var result03 = Quesion01.IsZigzag(arr);

            Assert.Equal(false, result03);
        }
        [Fact]
        public void Quesion01_FourItemsUpDown_ReturnTrue()
        {
            int[] arr = { 5, 6, 4 ,5};

            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result02);

            arr = new[] { 5, 6, 7,7};


            var result03 = Quesion01.IsZigzag(arr);

            Assert.Equal(false, result03);
        }
        [Fact]
        public void Quesion01_FourItemsDownUp_ReturnTrue()
        {
            int[] arr = { 6, 4, 5,1 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.Equal(true, result02);

            arr = new[] { 6,4,5,5};


            var result03 = Quesion01.IsZigzag(arr);

            Assert.Equal(false, result03);
        }


    }
}
