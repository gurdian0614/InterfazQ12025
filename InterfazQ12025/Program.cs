
using InterfazQ12025;

Operacion operacion = new Operacion();

Console.WriteLine("Ingrese primer número:");
operacion.N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese segundo número:");
operacion.N2 = Convert.ToInt32(Console.ReadLine());

operacion.Imprimir();
