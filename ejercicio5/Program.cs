using System;

namespace ejercicio5
{
    internal class Program
    {
        delegate int Operacion(int x, int y);

        static int Sumar(int x, int y)
        {
            return x + y;
        }

        static int Restar(int x, int y)
        {
            return x - y;
        }

        static int Multiplicar(int x, int y)
        {
            return x * y;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static void EjecutarOperacion(Operacion delegado, int num1, int num2)
        {
            Console.WriteLine("Resultado: " + delegado(num1, num2));
        }

        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            EjecutarOperacion(Sumar, num1, num2);
            EjecutarOperacion(Restar, num1, num2);
            EjecutarOperacion(Multiplicar, num1, num2);

            if (num2 != 0)
            {
                EjecutarOperacion(Division, num1, num2);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
    }
}
