using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTest2023.Q03;
using Xunit;

namespace TestingFinalTest
{
    public class Q03_First3CubesWithSameColorDiffSizeOrSameSizeDifColor
    {
        [Fact]
        public void CubeTowerFirst3Cubes_LessThan3_ReturnFalse()
        {
            CubeTower cubeTower = new CubeTower(0, new Cube[8]);

            bool result = cubeTower.First3CubesWithSameColorDiffSizeOrSameSizeDifColor();

            Assert.False(result);
        }
        [Fact]
        public void CubeTowerFirst3Cubes_Null_ReturnFalse()
        {
            CubeTower cubeTower = new CubeTower(0, null);

            bool result = cubeTower.First3CubesWithSameColorDiffSizeOrSameSizeDifColor();

            Assert.False(result);
        }
        [Fact]
        public void CubeTowerFirst3Cubes_SameColorDiffSize_ReturnTrue()
        {
            Cube[] cubes =
            {
                new Cube(1, "w"),
                new Cube(2, "w"),
                new Cube(3, "w"),
            };

            CubeTower cubeTower = new CubeTower(3, cubes);


            bool result = cubeTower.First3CubesWithSameColorDiffSizeOrSameSizeDifColor();

            Assert.True(result);
        }[Fact]
        public void CubeTowerFirst3Cubes_SameSizeDiffColor_ReturnTrue()
        {
            Cube[] cubes =
            {
                new Cube(1, "w"),
                new Cube(1, "b"),
                new Cube(1, "g"),
            };

            CubeTower cubeTower = new CubeTower(3, cubes);


            bool result = cubeTower.First3CubesWithSameColorDiffSizeOrSameSizeDifColor();

            Assert.True(result);
        }
        [Fact]
        public void CubeTowerFirst3Cubes_SameSizeSameColor_ReturnTrue()
        {
            Cube[] cubes =
            {
                new Cube(1, "w"),
                new Cube(1, "w"),
                new Cube(1, "w"),
            };

            CubeTower cubeTower = new CubeTower(3, cubes);


            bool result = cubeTower.First3CubesWithSameColorDiffSizeOrSameSizeDifColor();

            Assert.False(result);
        }
        [Fact]
        public void CubeTowerFirst3Cubes_DiffSizeDiffColor_ReturnTrue()
        {
            Cube[] cubes =
            {
                new Cube(1, "w"),
                new Cube(1, "y"),
                new Cube(2, "w"),
            };

            CubeTower cubeTower = new CubeTower(3, cubes);


            bool result = cubeTower.First3CubesWithSameColorDiffSizeOrSameSizeDifColor();

            Assert.False(result);
        }
    }
}
