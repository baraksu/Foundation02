using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gim2019;

namespace Gim2019Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Player p = new Player(1);

            p.Cards = new HiTechCard[30];

            p.Cards[0] = new HiTechCard("a1", 2, "a");
            p.Cards[1] = new HiTechCard("a2", 2, "a");
            p.Cards[2] = new HiTechCard("a3", 2, "a");
            p.Cards[3] = new HiTechCard("b1", 2, "b");

            Assert.AreEqual(1,p.GetNumberOfType(),"Only a");
        }
    }
}
