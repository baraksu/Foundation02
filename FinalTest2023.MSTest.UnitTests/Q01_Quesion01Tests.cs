using FinalTest2023.Q01;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest2023.Xunit.UnitTests
{
    [TestClass]
    public class Q01_Quesion01Tests

    {
        [TestMethod]
        public void Quesion01_Null_ReturnTrue()
        {
            int[] arr = null;

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result02);

        }
        [TestMethod]
        public void Quesion01_OneItem_ReturnTrue()
        {
            int[] arr = { 5 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result02);
        }
        [TestMethod]
        public void Quesion01_TwoItemsEquals_ReturnFalse()
        {
            int[] arr = { 5, 5 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(false, result02);
        }
        [TestMethod]
        public void Quesion01_TwoItemsNotEquals_ReturnTrue()
        {
            int[] arr = { 5, 6 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result02);

            arr = new[] { 6, 5 };


            var result03 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result03);
        }
        [TestMethod]
        public void Quesion01_ThreeItemsUpDown_ReturnTrue()
        {
            int[] arr = { 5, 6, 4 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result02);

            arr = new[] { 5, 6, 7 };


            var result03 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(false, result03);
        }
        [TestMethod]
        public void Quesion01_FourItemsUpDown_ReturnTrue()
        {
            int[] arr = { 5, 6, 4, 5 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result02);

            arr = new[] { 5, 6, 7, 7 };


            var result03 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(false, result03);
        }
        [TestMethod]
        public void Quesion01_FourItemsDownUp_ReturnTrue()
        {
            int[] arr = { 6, 4, 5, 1 };

            var result02 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(true, result02);

            arr = new[] { 6, 4, 5, 5 };


            var result03 = Quesion01.IsZigzag(arr);

            Assert.AreEqual(false, result03);
        }

        static IEnumerable<object[]> ArrayIsZigzag
        {
            get
            {

                return new[]
                {
                    new object[] { null, true},
                    new object[] { new int[0] { } , true},
                    new object[] { new int[] { 5 }, true },
                    new object[] { new int[] { 5, 6, 4 }, true },
                    new object[] { new int[] { 5, 6, 4, 5 },true },
                    new object[] { new int[] { 6, 4, 5, 1 }, true },
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(ArrayIsZigzag))]
        public void Quesion01_ArrayIsZigzag_ReturnTrue(int[] arr, bool expectedResult)
        {

            var actualResult = Quesion01.IsZigzag(arr);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [DataRow(new int[] { 5, 5 }, false)]
        [DataRow(new int[] { 5, 6, 7 }, false)]
        [DataRow(new int[] { 5, 6, 7, 7 }, false)]
        [DataRow(new int[] { 6, 4, 5, 5 }, false)]
        [DataRow(new int[] { 6, 4, 5, 5 }, false)]
        [DataRow(new int[] { 5 }, true)]
        [DataRow(new int[] { 5 ,6, 3,1 }, true)]

        public void Quesion01_ArrayIsZigzag_ReturnExpected(int[] arr, bool expectedResult)
        {

            var actualResult = Quesion01.IsZigzag(arr);

            Assert.AreEqual(expectedResult, expectedResult);
        }


    }
}
