using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bagrut_2023Q01;

namespace Bagrut2023
{
    public class Bagrut2023Q1Tests
    {

        [Fact]
        public void PostOrder_AllUp_True()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            Assert.True(
                Bagrut20203Q01.PosOrder(arr1));
        }
        [Fact]
        public void PostOrder_OneNegative_True()
        {
            int[] arr1 = { 1, -3, 3, 4, 5 };
            Assert.True(
                Bagrut20203Q01.PosOrder(arr1));
        }
        [Fact]
        public void PostOrder_TwoNegativeDown_True()
        {
            int[] arr1 = { 1, -3, 3, 4, -5 };
            Assert.True(
                Bagrut20203Q01.PosOrder(arr1));
        }
       
        [Fact]
        public void PostOrder_TwoPositiveDown_False()
        {
            int[] arr1 = { 1, -3, 3, 2, -5 };
            Assert.False(
                Bagrut20203Q01.PosOrder(arr1));
        }
        [Fact]
        public void PostOrder_TwoPositiveSameValue_False()
        {
            int[] arr1 = { 1, -3, 3, 3, -5 };
            Assert.True(
                Bagrut20203Q01.PosOrder(arr1));
        }
    }
}
