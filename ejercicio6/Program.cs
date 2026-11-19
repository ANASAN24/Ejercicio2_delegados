using System;

namespace ejercicio6
{
    internal class Program
    {
        delegate int Operar(int x, int y);

        static int Suma(int x, int y)
        {
            return x + y;
        }

        static int Resta(int x, int y)
        {
            return x - y;
        }

        static int Multiplicacion(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Operar delegado;

            Operar[] operaciones = { Suma, Resta, Multiplicacion };

            string[] nombres = { "Suma", "Resta", "Multiplicación" };

            for (int i = 0; i < operaciones.Length; i++)
            {
                delegado = operaciones[i];

                Console.WriteLine(nombres[i] + ": " + delegado(num1, num2));
            }
        }
    }
}
