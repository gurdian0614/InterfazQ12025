
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace InterfazQ12025
{
    public class Operacion : IOperacion, IArea
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public double Cuadrado()
        {
            return N1 * N1;
        }

        public double Division()
        {
            if (N2 == 0) {
                Console.WriteLine("No se puede dividir entre cero");
                return 0;
            }

            return N1 / N2;
        }

        public double Multiplicacion()
        {
            return N1 * N2;
        }

        public double Resta()
        {
            return N1 - N2;
        }

        public double Suma()
        {
            return N1 + N2;
        }

        public double Triangulo()
        {
            return (N1 * N2) / 2;
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Suma: {Suma()}");
            Console.WriteLine($"Resta: {Resta()}");
            Console.WriteLine($"Multiplicación: {Multiplicacion()}");
            Console.WriteLine($"División: {Division()}");
            Console.WriteLine($"Area del Cuadrado: {Cuadrado()} cm2");
            Console.WriteLine($"Area del Triángulo: {Triangulo()} cm2");
        }
    }
}
