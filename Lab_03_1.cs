using System;

namespace Lab_03_1
{
    class Program
    {

        class Vector
        {
            double _x;
            double _y;
            double _z;
            public double Length { get => Math.Sqrt(Math.Pow(_x, 2) +
                                                    Math.Pow(_y, 2) +
                                                    Math.Pow(_z, 2)); }
            public Vector(double x, double y, double z)
            {
                _x = x;
                _y = y;
                _z = z;
            }

            public double X { get => _x; }
            public double Y { get => _y; }
            public double Z { get => _z; }
            public static Vector operator +(Vector a, Vector b)
            {
                return new Vector(a._x + b._x , a._y + b._y, a._z + b._z);
            }

            public static double operator *(Vector a, Vector b) =>
                a._x * b._x + a._y * b._y + a._z * b._z;
            
            public static Vector operator *(Vector a, double b) => 
                new Vector(a._x * b, a._y * b, a._z * b);

            public static bool operator ==(Vector a, Vector b) =>
                a.Length == b.Length;
            public static bool operator !=(Vector a, Vector b) =>
                a.Length != b.Length;
            public static bool operator <(Vector a, Vector b) =>
                a.Length < b.Length;
            public static bool operator >(Vector a, Vector b) =>
                a.Length > b.Length;

        }
        static void Main(string[] args)
        {
            Vector test1 = new Vector(1, 2, 3);
            Vector test2 = new Vector(5, 3, -4);

            Console.WriteLine($"test1 = " +
                $"[ {test1.X} ; {test1.Y} ; {test1.Z} ]");
            Console.WriteLine($"test2 = " +
                $"[ {test2.X} ; {test2.Y} ; {test2.Z} ]");

            Vector test3 = test1 + test2;
            Console.WriteLine($"test1 + test2 = " +
                $"[ {test3.X} ; {test3.Y} ; {test3.Z} ]");

            test3 = test1 * 3;
            Console.WriteLine($"test1 * 3 = " +
                $"[ {test3.X} ; {test3.Y} ; {test3.Z} ]");

            Console.WriteLine($"test1 * test2 = " +
                $"{test1 * test2}");

            if (test1 > test2) Console.WriteLine($"test1 > test2");
            if (test1 < test2) Console.WriteLine($"test1 < test2");
            if (test1 == test2) Console.WriteLine($"test1 == test2");

        }
    }
}
