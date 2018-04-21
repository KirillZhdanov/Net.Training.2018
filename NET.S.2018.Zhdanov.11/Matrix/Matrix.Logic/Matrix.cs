using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public abstract class Matrix<T>
        where T:IComparable<T>
    {
        #region Public Field

        public virtual T[][] MatrixValues { get; protected set; }

        #endregion

        #region Constructor

        public Matrix(T[][] matrixValues)
        {
            MatrixValues = matrixValues;
        }

        #endregion

        #region Indexer

        public T this[int i, int j] =>
            MatrixValues[i][j];

        #endregion

        #region Public Method

        public virtual void SetElement(int i, int j, T value)
        {
            MatrixValues[i][j] = value;
            ElementIsChanged(i, j);
        }

        #endregion

        #region Protected Method

        protected void ElementIsChanged(int i, int j)
        {
            ChangedElement?.Invoke(this, new IfChanged(i, j));
        }

        #endregion

        #region Event

        public event EventHandler<IfChanged> ChangedElement;

        #endregion


    }
}
