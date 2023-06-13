using FinalTest2023.Q03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinalTest2023.Xunit.UnitTests
{
    [TestClass]
    public class Q03_CubeTowerAddMin
    {
        [TestMethod]
        public void OnlyOneCube_AddTheFirstCube()
        {
            var arrCubes = new Cube[8];
            arrCubes[0] = new Cube(1, "w");

            CubeTower cubeTower = new CubeTower(1, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.AreEqual(1, returnArrCubes[0].GetSize());
            Assert.AreEqual("w", returnArrCubes[0].GetColor());

            Assert.AreEqual(1, returnArrCubes[1].GetSize());
            Assert.AreEqual("w", returnArrCubes[1].GetColor());


        }
        [TestMethod]
        public void TwoCubesWithEmptySpace_AddTheFirstCube()
        {
            var arrCubes = new Cube[8];
            arrCubes[0] = new Cube(1, "w");
            arrCubes[1] = new Cube(2, "r");

            CubeTower cubeTower = new CubeTower(2, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.AreEqual(1, returnArrCubes[0].GetSize());
            Assert.AreEqual("w", returnArrCubes[0].GetColor());

            Assert.AreEqual(2, returnArrCubes[1].GetSize());
            Assert.AreEqual("r", returnArrCubes[1].GetColor());

            Assert.AreEqual(1, returnArrCubes[2].GetSize());
            Assert.AreEqual("w", returnArrCubes[2].GetColor());

            Assert.AreEqual(3,cubeTower.GetActualCubes());



        }
        [TestMethod]
        public void TwoCubesWithNoEmptySpace_AddTheFirstCube()
        {
            var arrCubes = new Cube[2];
            arrCubes[0] = new Cube(1, "w");
            arrCubes[1] = new Cube(2, "r");

            CubeTower cubeTower = new CubeTower(2, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.AreEqual(1, returnArrCubes[0].GetSize());
            Assert.AreEqual("w", returnArrCubes[0].GetColor());

            Assert.AreEqual(2, returnArrCubes[1].GetSize());
            Assert.AreEqual("r", returnArrCubes[1].GetColor());

            Assert.AreEqual(1, returnArrCubes[2].GetSize());
            Assert.AreEqual("w", returnArrCubes[2].GetColor());

            Assert.AreEqual(3, cubeTower.GetActualCubes());



        }
        [TestMethod]
        public void TwoCubesWithSpaceMinIsSecond_AddTheFirstCube()
        {
            var arrCubes = new Cube[2];
            arrCubes[0] = new Cube(2, "w");
            arrCubes[1] = new Cube(1, "r");

            CubeTower cubeTower = new CubeTower(2, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.AreEqual(2, returnArrCubes[0].GetSize());
            Assert.AreEqual("w", returnArrCubes[0].GetColor());

            Assert.AreEqual(1, returnArrCubes[1].GetSize());
            Assert.AreEqual("r", returnArrCubes[1].GetColor());

            Assert.AreEqual(1, returnArrCubes[2].GetSize());
            Assert.AreEqual("r", returnArrCubes[2].GetColor());

            Assert.AreEqual(3, cubeTower.GetActualCubes());



        }

    }
}
