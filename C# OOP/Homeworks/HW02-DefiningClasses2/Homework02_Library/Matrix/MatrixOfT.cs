

namespace Homework02_Library.Matrix
{
    using System;

    
    public class MatrixOfT<T> : IComparable<T> where T : IComparable<T>
    {
        private T[,] content;

        public T Content { get; set; }

        public MatrixOfT()
        {
            content = new T[3, 3];
        }
        public MatrixOfT(int colSize, int rowSize)
        {
            content = new T[colSize, rowSize];
        }

        public void FillIntMatrix()
        {
            Random rnd = new Random();

            for (int i = 0; i < this.content.GetLength(0); i++)
            {
                for (int j = 0; j < this.content.GetLength(1); j++)
                {
                    this.content[i, j] = (dynamic)rnd.Next(0, 9);
                }
            }
        }

        public T this [int col, int row]
        {
            get
            {
                return this.content[col, row];
            }
            set
            {
                this.content[col, row] = value;
            }
        }
        public static MatrixOfT<T> operator +(MatrixOfT<T> firstMatrix, MatrixOfT<T> secondMatrix)
        {
            if (firstMatrix.content.GetLength(0) != secondMatrix.content.GetLength(0) || firstMatrix.content.GetLength(1) != secondMatrix.content.GetLength(1))
            {
                throw new NotSupportedException("The matrices cannot perform addition if they are different sizes.");
            }

            MatrixOfT<T> result = new MatrixOfT<T>(firstMatrix.content.GetLength(0), firstMatrix.content.GetLength(1));

            for (int i = 0; i < firstMatrix.content.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.content.GetLength(1); j++)
                {
                    result[i, j] = ((dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j]);
                }
            }
            return result;
        }
        public static MatrixOfT<T> operator -(MatrixOfT<T> firstMatrix, MatrixOfT<T> secondMatrix)
        {
            if (firstMatrix.content.GetLength(0) != secondMatrix.content.GetLength(0) || firstMatrix.content.GetLength(1) != secondMatrix.content.GetLength(1))
            {
                throw new NotSupportedException("The matrices cannot perform addition if they are different sizes.");
            }

            MatrixOfT<T> result = new MatrixOfT<T>(firstMatrix.content.GetLength(0), firstMatrix.content.GetLength(1));

            for (int i = 0; i < firstMatrix.content.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.content.GetLength(1); j++)
                {
                    result[i, j] = ((dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j]);
                }
            }
            return result;
        }
        public static MatrixOfT<T> operator *(MatrixOfT<T> firstMatrix, MatrixOfT<T> secondMatrix)
        {
            if (firstMatrix.content.GetLength(1) != secondMatrix.content.GetLength(0))
            {
                throw new ArgumentException("Invalid matrices size! The matrices cannot be multiplied!");
            }

            var result = new MatrixOfT<T>(firstMatrix.content.GetLength(0), secondMatrix.content.GetLength(1));
            T sum;
            for (int i = 0; i < result.content.GetLength(0); i++)
            {
                for (int j = 0; j < result.content.GetLength(1); j++)
                {
                    sum = (dynamic)0;
                    for (int k = 0; k < firstMatrix.content.GetLength(1); k++)
                    {
                        sum += (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }
        public static bool operator true(MatrixOfT<T> matrix)
        {
            for (int i = 0; i < matrix.content.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.content.GetLength(1); j++)
                {
                    if (object.Equals(matrix[i,j], default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(MatrixOfT<T> matrix)
        {
            for (int i = 0; i < matrix.content.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.content.GetLength(1); j++)
                {
                    if (object.Equals(matrix[i, j], default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            string forReturn = "{ ";
            for (int i = 0; i < this.content.GetLength(0); i++)
            {
                for (int j = 0; j < this.content.GetLength(1); j++)
                {
                    if (j+1 == this.content.GetLength(1))
                    {
                        forReturn += this.content[i, j];
                        continue;
                    }
                    forReturn += this.content[i, j] + ",";
                }
                if (i+1==this.content.GetLength(0))
                {
                    forReturn += " }";
                    continue;
                }
                forReturn += "\n  ";
            }
            return forReturn;
        }
        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
