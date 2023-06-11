using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2023.Q03
{
    public class CubeTower
    {
        private int actualCubes;

        private Cube[] arrCubes;

        public int GetActualCubes()
        {
            return actualCubes;
        }

        public void SetActualCubes(int actualCubes)
        {
            this.actualCubes= actualCubes;
        }

        public Cube[] GetArrCubes()
        {
            return arrCubes;
        }

        public void SetArrCubes(Cube[] arrCubes)
        {
            if (arrCubes == null)
                return;
            this.arrCubes= new Cube[arrCubes.Length];

            for (int i = 0; i < arrCubes.Length; i++)
            {
                this.arrCubes[i] = arrCubes[i];
            }
        }

        public CubeTower(int actualCubes, Cube[] arrCubes)
        {
            this.actualCubes = actualCubes;

            this.SetArrCubes(arrCubes);

        }

        public bool First3CubesWithSameColorDiffSizeOrSameSizeDifColor()
        {
            if (this.arrCubes == null)
                return false;
            
            if (this.GetActualCubes() < 3)
                return false;

            if (this.GetArrCubes().GetLength(0) < 3)
                return false;

            if (this.arrCubes[0].GetColor() == this.arrCubes[1].GetColor() &&
                this.arrCubes[0].GetColor() == this.arrCubes[2].GetColor() &&
                this.arrCubes[1].GetColor() == this.arrCubes[2].GetColor() 
                )
                if (this.arrCubes[0].GetSize() != this.arrCubes[1].GetSize() ||
                    this.arrCubes[0].GetSize() != this.arrCubes[2].GetSize() ||
                    this.arrCubes[1].GetSize() != this.arrCubes[2].GetSize())
                {
                    return true;
                }
            if (this.arrCubes[0].GetSize() == this.arrCubes[1].GetSize() &&
                this.arrCubes[0].GetSize() == this.arrCubes[2].GetSize() &&
                this.arrCubes[1].GetSize() == this.arrCubes[2].GetSize()
               )
                if (this.arrCubes[0].GetColor() != this.arrCubes[1].GetColor() ||
                    this.arrCubes[0].GetColor() != this.arrCubes[2].GetColor() ||
                    this.arrCubes[1].GetColor() != this.arrCubes[2].GetColor())
                {
                    return true;
                }

            return false;

        }
    }
}
