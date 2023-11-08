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
class Lab4_1
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
/*using System;
using System.Collections.Generic;

public class Car
{
    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string name, int productionYear, int maxSpeed)
    {
        Name = name;
        ProductionYear = productionYear;
        MaxSpeed = maxSpeed;
    }

    public override string ToString()
    {
        return $"{Name}, {ProductionYear}, {MaxSpeed} ";
    }
}

// Определение класса CarComparer
public class CarComparer : IComparer<Car>
{
    public enum SortBy
    {
        Name,
        ProductionYear,
        MaxSpeed
    }

    public SortBy SortingBy { get; set; }

    public CarComparer(SortBy sortBy)
    {
        SortingBy = sortBy;
    }

    public int Compare(Car x, Car y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        int result;
        switch (SortingBy)
        {
            case SortBy.Name:
                result = string.Compare(x.Name, y.Name);
                break;
            case SortBy.ProductionYear:
                result = x.ProductionYear.CompareTo(y.ProductionYear);
                break;
            case SortBy.MaxSpeed:
                result = x.MaxSpeed.CompareTo(y.MaxSpeed);
                break;
            default:
                throw new ArgumentException("Invalid sorting option");
        }

        return result;
    }
}

class Lab4_2
{
    static Car[] GetCarsFromUser()
    {
        Console.Write("Enter the number of cars: ");
        int carCount = int.Parse(Console.ReadLine());
        Car[] cars = new Car[carCount];

        for (int i = 0; i < carCount; i++)
        {
            Console.WriteLine($"Enter details for car #{i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Production Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Max Speed: ");
            int speed = int.Parse(Console.ReadLine());

            cars[i] = new Car(name, year, speed);
        }

        return cars;
    }

    static void Main()
    {
        Car[] cars = GetCarsFromUser();

        Array.Sort(cars, new CarComparer(CarComparer.SortBy.Name));
        Console.WriteLine("Sorted by Name:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }

        Array.Sort(cars, new CarComparer(CarComparer.SortBy.ProductionYear));
        Console.WriteLine("\nSorted by Production Year:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }

        Array.Sort(cars, new CarComparer(CarComparer.SortBy.MaxSpeed));
        Console.WriteLine("\nSorted by Max Speed:");
        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
*/
using System;
using System.Collections.Generic;

// Класс Car, предоставленный в задании №2
public class Car
{
    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public int MaxSpeed { get; set; }

    public Car(string name, int productionYear, int maxSpeed)
    {
        Name = name;
        ProductionYear = productionYear;
        MaxSpeed = maxSpeed;
    }

    public override string ToString()
    {
        return $"{Name}, {ProductionYear}, {MaxSpeed} km/h";
    }
}

// Класс CarCatalog, содержащий массив Car и методы итерации
public class CarCatalog
{
    private Car[] cars;

    public CarCatalog(Car[] cars)
    {
        this.cars = cars;
    }

    // Прямой проход с первого элемента до последнего
    public IEnumerable<Car> Forward()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            yield return cars[i];
        }
    }

    // Обратный проход от последнего к первому
    public IEnumerable<Car> Reverse()
    {
        for (int i = cars.Length - 1; i >= 0; i--)
        {
            yield return cars[i];
        }
    }

    // Проход по элементам массива с фильтром по году выпуска
    public IEnumerable<Car> FilterByYear(int year)
    {
        foreach (var car in cars)
        {
            if (car.ProductionYear == year)
            {
                yield return car;
            }
        }
    }

    // Проход по элементам массива с фильтром по максимальной скорости
    public IEnumerable<Car> FilterByMaxSpeed(int speed)
    {
        foreach (var car in cars)
        {
            if (car.MaxSpeed == speed)
            {
                yield return car;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Пример использования
        Car[] cars = new Car[]
        {
            new Car("Toyota", 2020, 180),
            new Car("Ford", 2019, 190),
            new Car("BMW", 2021, 200),
            new Car("Tesla", 2022, 250)
        };

        CarCatalog catalog = new CarCatalog(cars);

        Console.WriteLine("Forward iteration:");
        foreach (var car in catalog.Forward())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("\nReverse iteration:");
        foreach (var car in catalog.Reverse())
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("\nFilter by year (2020):");
        foreach (var car in catalog.FilterByYear(2020))
        {
            Console.WriteLine(car);
        }

        Console.WriteLine("\nFilter by max speed (190):");
        foreach (var car in catalog.FilterByMaxSpeed(190))
        {
            Console.WriteLine(car);
        }
    }
}
