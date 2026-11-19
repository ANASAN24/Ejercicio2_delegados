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

        static int Restar(int x, int y)
        {
            return x - y;
        }

        static int Multiplicar(int x, int y)
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

            Operacion delegadoSumar = Sumar;
            Operacion delegadoRestar = Restar;
            Operacion delegadoMultiplicar = Multiplicar;

            Console.WriteLine("La suma es: " + delegadoSumar(num1, num2));
            Console.WriteLine("La resta es: " + delegadoRestar(num1, num2));
            Console.WriteLine("La multiplicación es: " + delegadoMultiplicar(num1, num2));
        }
    }
}

