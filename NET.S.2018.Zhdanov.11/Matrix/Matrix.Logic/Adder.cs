using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{

    public static class Adder
    {

        #region Public Method

        public static SquareMatrix<T> Sum<T>(this SquareMatrix<T> matrix, SquareMatrix<T> other)
            where T : IComparable<T>
        {
            Checker(matrix, other);
            if (matrix.Size != other.Size)
                throw new InvalidOperationException("Different sizes of matrixes.");

            return GetSum(matrix, other);
        }

        #endregion

        #region Private Methods

        private static void Checker<T>(Matrix<T> matrix, Matrix<T> other)
            where T : IComparable<T>
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));
            if (other == null)
                throw new ArgumentNullException(nameof(other));
        }

        private static T[][] ClearArray<T>(SquareMatrix<T> matrix)
            where T : IComparable<T>
        {
            var newMatrixValues = new T[matrix.Size][];
            for (int i = 0; i < matrix.Size; i++)
                newMatrixValues[i] = new T[matrix.Size];

            return newMatrixValues;
        }

        private static SquareMatrix<T> GetSum<T>(SquareMatrix<T> matrix, SquareMatrix<T> other)
            where T : IComparable<T>
        {
            var newMatrixValues = ClearArray(matrix);

            try
            {
                for (int i = 0; i < matrix.Size; i++)
                    for (int j = 0; j < matrix.Size; j++)
                        newMatrixValues[i][j] = (dynamic)matrix[i, j] + other[i, j];
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return new SquareMatrix<T>(newMatrixValues);
        }

        #endregion

    }
}
