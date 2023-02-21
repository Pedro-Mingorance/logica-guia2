using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
        double importe;
        const double descuentointermedio = 1000;
        const double descuentoprincipal = 5000;
        const double descuentomenor = 0.90;
        const double descuentomayor = 0.82;

        Console.WriteLine("Ingrese el importe total:");
        importe = double.Parse(Console.ReadLine());

        if(importe > descuentoprincipal){
            importe = importe * descuentomayor;
        }else{
            if(importe > descuentointermedio){
                importe = importe * descuentomenor;
            }
        }
        Console.WriteLine("El importe total es: " + importe);
        }
    }
}
