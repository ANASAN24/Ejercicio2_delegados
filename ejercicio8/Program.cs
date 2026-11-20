using System;

namespace ejercicio8
{
    internal class Program
    {
        delegate int Transformar(int x);

        static int Doblar(int x)
        {
            return x * 2;
        }

        static int Triplicar(int x)
        {
            return x * 3;
        }

        static int Cuadrado(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            int num;

            Console.Write("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            Transformar delegado;

            Transformar[] operaciones = { Doblar, Triplicar, Cuadrado };

            string[] nombres = { "Doblar", "Triplicar", "Cuadrado" };

            for (int i = 0; i < operaciones.Length; i++)
            {
                delegado = operaciones[i];

                Console.WriteLine(nombres[i] + ": " + delegado(num));
            }
        }
    }
}
