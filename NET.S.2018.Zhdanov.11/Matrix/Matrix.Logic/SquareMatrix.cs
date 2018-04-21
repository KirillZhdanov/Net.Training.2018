using System;

namespace Matrix
{
    public class SquareMatrix<T> : Matrix<T> 
        where T:IComparable<T>
    {
        public SquareMatrix(T[][] matrixValues) : base(matrixValues)
        {
            if (MatrixValues == null)
                throw new ArgumentNullException(nameof(MatrixValues));
            if (MatrixValues.Length != Size)
                throw new ArgumentException("Size is not equal");
            
        }
        public override T[][] MatrixValues { get => base.MatrixValues; protected set => base.MatrixValues = value; }

        public int Size { get { return MatrixValues.Length; } }

        public override void SetElement(int i, int j, T value)
        {
            MatrixValues[i][j] = value;
            base.SetElement(i, j, value);
        }
    }
}
