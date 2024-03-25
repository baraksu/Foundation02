using FinalTest2023.Q02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinalTest2023.Xunit.UnitTests
{
    [TestClass]
    public class Q02_InOneOfDiagonalTests
    {
        [TestMethod]
        public void InOneOfDiagonal_null_ReturnTrue()
        {
            bool result = InOneOfDiagonalClass.AllArrayInOneOfDiagonal(null);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InOneOfDiagonal_NoItems_ReturnTrue()
        {
            int[,] arr = new int [0, 0];
            bool result = InOneOfDiagonalClass.AllArrayInOneOfDiagonal(arr);

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InOneOfDiagonal_OneItem_ReturnTrue()
        {
            int[,] arr = new int[1, 1];
            arr[0, 0] = 1;

            bool result = InOneOfDiagonalClass.AllArrayInOneOfDiagonal(arr);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InOneOfDiagonal_ItemIn_ReturnTrue()
        {
            int[,] arr = { { 1, 2, 3 }, { 2, 3, 1 }, { 3, 1, 2 } };


            bool result = InOneOfDiagonalClass.AllArrayInOneOfDiagonal(arr);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InOneOfDiagonal_ItemNotIn_ReturnFalse()
        {
            int[,] arr = { { 1, 4,2 }, { 2, 3, 1 }, { 3, 1, 2 } };


            bool result = InOneOfDiagonalClass.AllArrayInOneOfDiagonal(arr);

            Assert.IsFalse(result);
        }
    }
}
