using System;

namespace ejercicio2
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

        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Introduce el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Operacion delegado;

            delegado = Sumar;
            Console.WriteLine("La suma es: " + delegado(num1, num2));

            delegado = Restar;
            Console.WriteLine("La resta es: " + delegado(num1, num2));
        }
    }
}

