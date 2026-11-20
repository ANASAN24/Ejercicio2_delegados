using System;

namespace ejercicio9
{
    internal class Program
    {
        delegate int OperacionCallback(int x, int y);

        static int Suma(int x, int y)
        {
            return x + y;
        }

        static int Resta(int x, int y)
        {
            return x - y;
        }

        static int Multiplicar(int x, int y)
        {
            return x * y;
        }

        static int EjecutarOperacion(OperacionCallback delegado, int num1, int num2)
        {
            return delegado(num1, num2);
        }

        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resultado;

            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = EjecutarOperacion(Suma, num1, num2);
            Console.WriteLine("La suma es: " + resultado);

            resultado = EjecutarOperacion(Resta, num1, num2);
            Console.WriteLine("La resta es: " + resultado);

            resultado = EjecutarOperacion(Multiplicar, num1, num2);
            Console.WriteLine("La multiplicación es: " + resultado);
        }
    }
}