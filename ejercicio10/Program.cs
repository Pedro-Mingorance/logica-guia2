using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
         int n1, n2, n3, n4;
         const int n5 = 100;

        Console.WriteLine("Ingrese 4 numeros separados por la tecla enter: (recuerde que solo se mostraran los numeros superiores a 100) ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if(n1 > n5)
            Console.WriteLine(n1 + " es mayor a 100");

        if(n2 > n5)
            Console.WriteLine(n2 + " es mayor a 100");

        if(n3 > n5)
            Console.WriteLine(n3 + " es mayor a 100");

        if(n4 > n5)
            Console.WriteLine(n4 + " es mayor a 100");
        }
    }
}
