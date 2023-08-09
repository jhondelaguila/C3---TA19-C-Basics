
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA = 2;
            double numB = 3;

            Console.WriteLine("### EJERCICIO 1 ###");
            Console.WriteLine("suma 2 + 3 = " + (numA + numB));
            Console.WriteLine("resta 2 - 3 = " + (numA - numB));
            Console.WriteLine("multiplicacion 2 * 3 = " + (numA * numB));
            Console.WriteLine("divion 2 / 3 = " + (numA / numB));
            Console.WriteLine("modulo 3 % 2 = " + (numB % numA));

            Console.WriteLine("\n");
            Console.WriteLine("### EJERCICIO 2 ###");

            int N = 1;
            double A = 2.3;
            char C = 'C';

            Console.WriteLine("El valor de N: " + N);
            Console.WriteLine("El valor de A: " + A);
            Console.WriteLine("El valor de C: " + C);
            Console.WriteLine("suma 1 + 2.3 = " + (N + A));
            Console.WriteLine("diferencia 1 - 2.3 = " + (A - N));
            int valorNumericoC = (int)C;
            Console.WriteLine("El valor numérico de C: " + valorNumericoC);

            Console.WriteLine("\n");
            Console.WriteLine("### EJERCICIO 3 ###");
            int X = 10;
            int Y = 5;
            double n = 12.5;
            double M = 2.5;

            Console.WriteLine("El valor de X: " + X);
            Console.WriteLine("El valor de Y: " + Y);
            Console.WriteLine("El valor de N: " + n);
            Console.WriteLine("El valor de M: " + M);

            Console.WriteLine("La suma X + Y: " + (X + Y));
            Console.WriteLine("La diferencia X - Y: " + (X - Y));
            Console.WriteLine("El producto X * Y: " + (X * Y));
            Console.WriteLine("El cociente X / Y: " + ((double)X / Y));
            Console.WriteLine("El resto X % Y: " + (X % Y));

            Console.WriteLine("La suma N + M: " + (n + M));
            Console.WriteLine("La diferencia N - M: " + (n - M));
            Console.WriteLine("El producto N * M: " + (n * M));
            Console.WriteLine("El cociente N / M: " + (n / M));
            Console.WriteLine("El resto N % M: " + (n % M));

            Console.WriteLine("La suma X + N: " + (X + n));
            Console.WriteLine("El cociente Y / M: " + ((double)Y / M));
            Console.WriteLine("El resto Y % M: " + (Y % (int)M));

            Console.WriteLine("El doble de X: " + (X * 2));
            Console.WriteLine("El doble de Y: " + (Y * 2));
            Console.WriteLine("El doble de N: " + (n * 2));
            Console.WriteLine("El doble de M: " + (M * 2));

            double sumaTotal = X + Y + n + M;
            Console.WriteLine("La suma de todas las variables: " + sumaTotal);

            double productoTotal = X * Y * n * M;
            Console.WriteLine("El producto de todas las variables: " + productoTotal);


            Console.WriteLine("\n");
            Console.WriteLine("### EJERCICIO 4 ###");
            int Na = 1;

            Console.WriteLine("Valor inicial de N = " + Na);
            Na = Na + 77;
            Console.WriteLine("N + 77 = " + Na);
            Na = Na - 3;
            Console.WriteLine("N - 3 = " + Na);
            Na = Na * 2;
            Console.WriteLine("N * 2 = " + Na);

            Console.WriteLine("\n");
            Console.WriteLine("### EJERCICIO 5 ###");
            int Aa = 5;
            int B = 10;
            int Cc = 15;
            int D = 20;

            Console.WriteLine("Valores originales:");
            Console.WriteLine("A = " + Aa);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + Cc);
            Console.WriteLine("D = " + D);

            int temp = B;
            B = Cc;
            Cc = Aa;
            Aa = D;
            D = temp;

            Console.WriteLine("\nValores después de las operaciones:");
            Console.WriteLine("A = " + Aa);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + Cc);
            Console.WriteLine("D = " + D);
        }
    }
}