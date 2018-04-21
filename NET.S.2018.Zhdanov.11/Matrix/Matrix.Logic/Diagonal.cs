using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
   public class Diagonal<T> : SquareMatrix<T>
        where T : IComparable<T>
    {
        public Diagonal(T[][] matrixValues) : base(matrixValues)
        {
            if (MatrixValues == null)
                throw new ArgumentNullException(nameof(MatrixValues));
            if (MatrixValues.Length != Size)
                throw new ArgumentException("Size is not equal");
                
        }
       
        public override T[][] MatrixValues
        {
            get
            {
                return base.MatrixValues;
            }

            protected set
            {
                if (!Check(value))
                    throw new ArgumentException("Elements out of main diagonal is not default");
                base.MatrixValues = value;
            }
        }

     

        public override void SetElement(int i, int j, T value)
        {
            MatrixValues[i][j] = value;
            base.SetElement(i, j, value);
        }
        public bool Check(T[][] matrixValues)
        {
            for (int i = 0; i < matrixValues.Length; i++)
                for (int j = 0; j < matrixValues.Length; j++)
                    if (i!= j && matrixValues[i][j].CompareTo(default(T))!=0)
                        return false;

            return true;
        }

    }
}
