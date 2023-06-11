using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2023.Q03
{
    public class CubeTowerExtensions
    {
        public static void AddMinCubeTowerV01(CubeTower cubeTower)
        {
            var arrCubes = cubeTower.GetArrCubes();
            var actualCubes = cubeTower.GetActualCubes();
           
            // not null but with 0 items
            if (arrCubes.Length == 0)
                return;

            var sameAsMin = GetCubeSameAsMin(arrCubes, actualCubes);

            if (actualCubes < arrCubes.Length)
            {
                // put sameAsMin in the last place.
                cubeTower.GetArrCubes()[actualCubes] = sameAsMin;

                // add the actualCubes
                cubeTower.SetActualCubes(cubeTower.GetActualCubes()+ 1);
            }
            else
            {// not needed in the test.
             // any size which is bigger than arrCubes.Length
                //Cube[] newArr = new Cube[arrCubes.Length + 1];
                Cube[] newArr = new Cube[arrCubes.Length * 2];

                for (int i = 0; i < arrCubes.Length; i++)
                {
                    newArr[i] = arrCubes[i];
                }

                newArr[actualCubes] = sameAsMin;

                cubeTower.SetArrCubes (newArr);

                // add the actualCubes
                cubeTower.SetActualCubes(actualCubes + 1);

            }
        }

        private static Cube GetCubeSameAsMin(Cube[] arrCubes, int actualCubes)
        {
            Cube minCube = arrCubes[0];

            for (int i = 0; i < actualCubes; i++)
            {
                if (minCube.GetSize() > arrCubes[i].GetSize())
                {
                    minCube = arrCubes[i];
                }
            }

            Cube sameAsMin = new Cube(minCube.GetSize(), minCube.GetColor());
            return sameAsMin;
        }
    }
}
