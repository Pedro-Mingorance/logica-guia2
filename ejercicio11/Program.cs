using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3, n4;
        const int n5 = 100;
        int r = 0;

        Console.WriteLine("Ingrese 4 numeros separados por la tecla enter: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if(n1 < n5)
            r ++;

        if(n2 < n5)
            r ++;

        if(n3 < n5)
            r ++;
        
        if(n4 < n5)
            r ++;
        
        Console.WriteLine("La cantidad de numeros mayor a 100 es = " + r);
        }
    }
}
