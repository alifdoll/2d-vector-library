using System;

namespace AlifVector
{
    /// <summary>
    /// This class is used to create a 2d vector object
    /// </summary>
    public class Alif2DVector
    {
        private int x;
        private int y;

        /// <summary>
        /// Constructor object with predefined properties
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Alif2DVector(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Constructor without any predefined properties
        /// </summary>
        public Alif2DVector()
        {
            X = 0;
            Y = 0;
        }


        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    
    
    
        
        /// <summary>
        /// This method used to add current object
        /// with another vector object
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public Alif2DVector Add(Alif2DVector vector)
        {
            int xRes = X + vector.X;
            int yRes = Y + vector.Y;
            Alif2DVector vectorRes = new Alif2DVector(xRes, yRes);
            return vectorRes;
        }

        public Alif2DVector Add(int x, int y)
        {
            Alif2DVector vector = new Alif2DVector(x, y);
            return Add(vector);
        }

        public static Alif2DVector Add(Alif2DVector vector1, Alif2DVector vector2)
        {
            return vector1.Add(vector2);
        }

        public static Alif2DVector operator +(Alif2DVector vector1, Alif2DVector vector2)
        {
            Alif2DVector vectorRes = vector1.Add(vector2);
            return vector1.Add(vector2);
        }


        
        /// <summary>
        /// This Method used to substract current object
        /// with another vector object
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public Alif2DVector Substract(Alif2DVector vector)
        {
            int xRes = X - vector.X;
            int yRes = Y - vector.Y;
            Alif2DVector vectRes = new Alif2DVector(xRes, yRes);
            return vectRes;
        }

        public Alif2DVector Substract(int x, int y)
        {
            Alif2DVector vectRes = new Alif2DVector(x, y);
            return Substract(vectRes);
        }

        public static Alif2DVector Substract(Alif2DVector vector1, Alif2DVector vector2)
        {
            Alif2DVector vectRes = vector1.Substract(vector2);
            return vectRes;
        }

        public static Alif2DVector operator -(Alif2DVector vector1, Alif2DVector vector2)
        {
            return vector1.Substract(vector2);
        }


        public int DotProduct(Alif2DVector vector)
        {
            int xRes = X * vector.X;
            int yRes = Y * vector.Y;
            return xRes + yRes;
        }

        public int DotProduct(int x, int y)
        {
            Alif2DVector vector = new Alif2DVector(x, y);
            return DotProduct(vector);
        }

        /// <summary>
        /// This Method change the objects X and Y property
        /// by multiplying it with a real number
        /// </summary>
        /// <param name="constant"></param>
        public void ScalarMultiply(int constant)
        {
            X *= constant;
            Y *= constant;
        }


        /// <summary>
        /// This Method change the objects X and Y property
        /// by dividing it with a real number
        /// </summary>
        /// <param name="constant"></param>
        public void ScalarDivision(int constant)
        {
            if (constant == 0) throw new DivideByZeroException();
            X /= constant;
            Y /= constant;
        }


        /// <summary>
        /// This method is used to find the objects
        /// Norm
        /// </summary>
        /// <returns></returns>
        public double Norm()
        {
            double norm = Math.Sqrt((Math.Pow(X, 2) + Math.Pow(Y, 2)));
            return norm;
        }
    }
}
