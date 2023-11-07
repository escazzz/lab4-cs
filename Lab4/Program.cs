/*using System.Text;

public class MyMatrix
{
    private int[,] matrix;

    public MyMatrix(int rows, int cols, int rangeStart, int rangeEnd)
    {
        var random = new Random();
        matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(rangeStart, rangeEnd);
            }
        }
    }

    public MyMatrix Add(MyMatrix other)
    {
        if (this.matrix.GetLength(0) != other.matrix.GetLength(0) || this.matrix.GetLength(1) != other.matrix.GetLength(1))
        {
            throw new ArgumentException("Matrices are not the same size.");
        }

        var result = new MyMatrix(matrix.GetLength(0), matrix.GetLength(1), 0, 1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result.matrix[i, j] = this.matrix[i, j] + other.matrix[i, j];
            }
        }
        return result;
    }

    public MyMatrix Subtract(MyMatrix other)
    {
        if (this.matrix.GetLength(0) != other.matrix.GetLength(0) || this.matrix.GetLength(1) != other.matrix.GetLength(1))
        {
            throw new ArgumentException("Matrices are not the same size.");
        }

        var result = new MyMatrix(matrix.GetLength(0), matrix.GetLength(1), 0, 1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result.matrix[i, j] = this.matrix[i, j] - other.matrix[i, j];
            }
        }
        return result;
    }

    public MyMatrix Multiply(MyMatrix other)
    {
        if (this.matrix.GetLength(1) != other.matrix.GetLength(0))
        {
            throw new ArgumentException("Matrices are not compatible for multiplication.");
        }

        var result = new MyMatrix(matrix.GetLength(0), other.matrix.GetLength(1), 0, 1);
        for (int i = 0; i < result.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < result.matrix.GetLength(1); j++)
            {
                for (int k = 0; k < this.matrix.GetLength(1); k++)
                {
                    result.matrix[i, j] += this.matrix[i, k] * other.matrix[k, j];
                }
            }
        }
        return result;
    }

    public MyMatrix Multiply(int scalar)
    {
        var result = new MyMatrix(matrix.GetLength(0), matrix.GetLength(1), 0, 1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result.matrix[i, j] = this.matrix[i, j] * scalar;
            }
        }
        return result;
    }

    public MyMatrix Divide(int scalar)
    {
        var result = new MyMatrix(matrix.GetLength(0), matrix.GetLength(1), 0, 1);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result.matrix[i, j] = this.matrix[i, j] / scalar;
            }
        }
        return result;
    }

    public int this[int i, int j]
    {
        get { return matrix[i, j]; }
        set { matrix[i, j] = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sb.Append(matrix[i, j] + " ");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows for the matrix:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns for the matrix:");
        int cols = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the start of the range for the random values:");
        int rangeStart = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end of the range for the random values:");
        int rangeEnd = int.Parse(Console.ReadLine());

        MyMatrix matrix = new MyMatrix(rows, cols, rangeStart, rangeEnd);
        Console.WriteLine("Generated Matrix:");
        Console.WriteLine(matrix.ToString());

        // For example, to add two matrices:
        // MyMatrix anotherMatrix = new MyMatrix(rows, cols, rangeStart, rangeEnd);
        // MyMatrix sumMatrix = matrix.Add(anotherMatrix);
        // Console.WriteLine("Sum of both matrices:");
        // Console.WriteLine(sumMatrix.ToString());
    }
}
*/
