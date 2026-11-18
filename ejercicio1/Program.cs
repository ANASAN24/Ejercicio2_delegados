using System;

namespace ejercicio1
{
    internal class Program
    {
       
        delegate int Operacion(int x, int y);

        static int Sumar(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int resultado;

            
            Operacion delegadoSumar = Sumar;

            resultado = delegadoSumar(5, 3);

            Console.WriteLine("La suma es: " + resultado);

            Console.ReadKey();
        }
    }
}
