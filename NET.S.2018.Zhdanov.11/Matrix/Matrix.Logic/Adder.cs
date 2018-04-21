using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{

    public class Adder
    {

        private static SquareMatrix<T> GetSum<T>(SquareMatrix<T> matrix, SquareMatrix<T> other)
          where T : IComparable<T>
        {
            var SumofMatrix = new T[matrix.Size][];
            for (int i = 0; i < matrix.Size; i++)
                SumofMatrix[i] = new T[matrix.Size];

            for (int i = 0; i < matrix.Size; i++)
                    for (int j = 0; j < matrix.Size; j++)
                        SumofMatrix[i][j] = (dynamic)matrix[i, j] + other[i, j];
           
            

            return new SquareMatrix<T>(SumofMatrix);
        }

    }
}
