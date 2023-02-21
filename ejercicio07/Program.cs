using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3, n4, mayor;

        Console.WriteLine("Ingrese cuatro numeros separados por la tecla enter: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if(n1 > n2)
            mayor = n1;
        else
            mayor = n2;
        
        if(n3 > mayor)
            mayor = n3;
        
        if(n4 > mayor)
            mayor = n4;
        
        Console.WriteLine("El numero mayor es: " + mayor);
        }

        
    }
}
