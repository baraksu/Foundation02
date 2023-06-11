using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest2023.Q03;
using Xunit;

namespace TestingFinalTest
{
    public class Q03_CubeTowerAddMin
    {
        [Fact]
        public void OnlyOneCube_AddTheFirstCube()
        {
            var arrCubes = new Cube[8];
            arrCubes[0] = new Cube(1, "w");

            CubeTower cubeTower = new CubeTower(1, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.Equal(1, returnArrCubes[0].GetSize());
            Assert.Equal("w", returnArrCubes[0].GetColor());

            Assert.Equal(1, returnArrCubes[1].GetSize());
            Assert.Equal("w", returnArrCubes[1].GetColor());


        }
        [Fact]
        public void TwoCubesWithEmptySpace_AddTheFirstCube()
        {
            var arrCubes = new Cube[8];
            arrCubes[0] = new Cube(1, "w");
            arrCubes[1] = new Cube(2, "r");

            CubeTower cubeTower = new CubeTower(2, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.Equal(1, returnArrCubes[0].GetSize());
            Assert.Equal("w", returnArrCubes[0].GetColor());

            Assert.Equal(2, returnArrCubes[1].GetSize());
            Assert.Equal("r", returnArrCubes[1].GetColor());

            Assert.Equal(1, returnArrCubes[2].GetSize());
            Assert.Equal("w", returnArrCubes[2].GetColor());

            Assert.Equal(3,cubeTower.GetActualCubes());



        }
        [Fact]
        public void TwoCubesWithNoEmptySpace_AddTheFirstCube()
        {
            var arrCubes = new Cube[2];
            arrCubes[0] = new Cube(1, "w");
            arrCubes[1] = new Cube(2, "r");

            CubeTower cubeTower = new CubeTower(2, arrCubes);

            CubeTowerExtensions.AddMinCubeTowerV01(cubeTower);

            var returnArrCubes = cubeTower.GetArrCubes();

            Assert.Equal(1, returnArrCubes[0].GetSize());
            Assert.Equal("w", returnArrCubes[0].GetColor());

            Assert.Equal(2, returnArrCubes[1].GetSize());
            Assert.Equal("r", returnArrCubes[1].GetColor());

            Assert.Equal(1, returnArrCubes[2].GetSize());
            Assert.Equal("w", returnArrCubes[2].GetColor());

            Assert.Equal(3, cubeTower.GetActualCubes());



        }

    }
}
