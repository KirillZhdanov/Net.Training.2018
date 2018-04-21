using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Simmetric<T> : SquareMatrix<T>
         where T : IComparable<T>
    {
        public Simmetric(T[][] matrixValues):base (matrixValues)
        {
           
           MatrixValues = matrixValues ?? throw new ArgumentNullException(nameof(matrixValues));
        }

        public override T[][] MatrixValues
        {
            get
            {
                return base.MatrixValues;
            }

            protected set
            {
                if (!Check(value) )
                {
                    throw new ArgumentException("Matrix is not simmetric");
                }

                base.MatrixValues = value;
            }
        }

        public override void SetElement(int i, int j, T value)
        {
            base.SetElement(i, j, value);
        }
        public bool Check(T[][] matrixValues)
        {
            for(int i=0;i<matrixValues.Length;i++)
                for(int j = 0; j < matrixValues.Length; j++)
                    if(matrixValues[i][j].CompareTo(matrixValues[j][i])==0)
                        return true;

            return false;            
        }
    }
}
