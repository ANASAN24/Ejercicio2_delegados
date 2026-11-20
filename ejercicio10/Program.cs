using System;

namespace ejercicio10
{
    internal class Program
    {
        delegate double Calculo(double x);

        static double RaizCuadrada(double x)
        {
            if (x < 0)
            {
                throw new Exception("No se puede calcular la raiz cuadrada de un número negativo.");
            }

            return Math.Sqrt(x);
        }

        static double Logaritmo(double x)
        {
            if (x <= 0)
            {
                throw new Exception("No se puede calcular el logaritmo de cero o un número negativo.");
            }

            return Math.Log(x);
        }

        static void EjecutarCalculo(Calculo delegado, double num)
        {
            try
            {
                Console.WriteLine("Resultado: " + delegado(num));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            double num;

            Console.Write("Introduce un número: ");
            num = Convert.ToDouble(Console.ReadLine());

            EjecutarCalculo(RaizCuadrada, num);
            EjecutarCalculo(Logaritmo, num);
        }
    }
}
