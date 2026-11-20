using System;

namespace ejercicio7
{
    internal class Program
    {
        delegate int Operar(int[] numeros);

        static int Suma(int[] numeros)
        {
            int resultado = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                resultado = resultado + numeros[i];
            }

            return resultado;
        }

        static int Multiplicacion(int[] numeros)
        {
            int resultado = 1;

            for (int i = 0; i < numeros.Length; i++)
            {
                resultado = resultado * numeros[i];
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            int cantidad;

            Console.Write("¿Cuántos números quieres introducir? ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[cantidad];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Introduce el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Operar delegado;

            Operar[] operaciones = { Suma, Multiplicacion };

            string[] nombres = { "Suma", "Multiplicación" };

            for (int i = 0; i < operaciones.Length; i++)
            {
                delegado = operaciones[i];

                Console.WriteLine(nombres[i] + ": " + delegado(numeros));
            }
        }
    }
}