using System;


namespace Poly
{   

 public class Polynomial
  {
    private  double[] coeffs;

            ///<summary>
            ///  Poly init
            ///</summary>
            ///<param name = "coefficients">.</param>
   public Polynomial(params double[] coefficients)
   {
       coeffs = coefficients;
   }

          
     public double this[int n]
     {
         get { return coeffs[n]; }
         set { coeffs[n] = value; }              
     }

            ///<summary>
            ///  Polynom degree
            ///</summary>
       public int Degree
       {   
                get { return coeffs.Length; }
       }

        #region Static Methods

        ///<summary>
        ///  PolySum
        ///</summary>
        public static Polynomial operator +(Polynomial first, Polynomial second)
            {
                int itemsCount = Math.Max(first.coeffs.Length, second.coeffs.Length);
                var result = new double[itemsCount];
                for (int i = 0; i < itemsCount; i++)
                {
                    double a = 0;
                    double b = 0;
                    if (i < first.coeffs.Length)
                    {
                        a = first[i];
                    }
                    if (i < second.coeffs.Length)
                    {
                        b = second[i];
                    }
                    result[i] = a + b;
                }
                return new Polynomial(result);
            }

            ///<summary>
            /// PolynomSub
            ///</summary>
            public static Polynomial operator -(Polynomial first, Polynomial second)
            {
                int itemsCount = Math.Max(first.coeffs.Length, second.coeffs.Length);
                var result = new double[itemsCount];
                for (int i = 0; i < itemsCount; i++)
                {
                    double a = 0;
                    double b = 0;
                    if (i < first.coeffs.Length)
                    {
                        a = first[i];
                    }
                    if (i < second.coeffs.Length)
                    {
                        b = second[i];
                    }
                    result[i] = a - b;
                }
                return new Polynomial(result);
            }

            ///<summary>
            ///  Polynom Multiply
            ///</summary>
            public static Polynomial operator *(Polynomial first, Polynomial second)
            {
                int itemsCount = first.coeffs.Length + second.coeffs.Length - 1;
                var result = new double[itemsCount];
                for (int i = 0; i < first.coeffs.Length; i++)
                {
                    for (int j = 0; j < second.coeffs.Length; j++)
                    {
                        result[i + j] += first[i] * second[j];
                    }
                }

                return new Polynomial(result);
            }

            ///<summary>
            ///  Equality
            ///</summary>
            public static bool operator ==(Polynomial first, Polynomial second)
            {
                if (first.coeffs.Length != second.coeffs.Length)
                {
                    return false;
                }
                for (int i = 0; i < first.coeffs.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        return false;
                    }
                }
                return true;
            }

            public static bool operator !=(Polynomial first, Polynomial second)
            {
                return !(first == second);
            }
        #endregion
        public override string ToString()
        {
                return string.Format("Coefficients:" + string.Join(";", coeffs));
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Polynomial))
                throw new ArgumentException("Is not Polynomic");
            return this.Equals((Polynomial)obj);
        }
        ///<summary>
        ///  Calculating polynom
        ///</summary>
        ///<param name = "x">.</param>
        ///<returns></returns>
        public double Computation(double x)
        {
            int n = coeffs.Length - 1;
            double result = coeffs[n];
            for (int i = n - 1; i >= 0; i--)
            {
               result = x * result + coeffs[i];
            }
                return result;          
        }

 }
    

}
