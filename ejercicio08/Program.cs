using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3, n4, menor;

        Console.WriteLine("Ingrese cuatro numeros separados por la tecla enter: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());

        if(n1 < n2)
            menor = n1;
        else
            menor = n2;
        
        if(n3 < menor)
            menor = n3;
        
        if(n4 < menor)
            menor = n4;
        
        Console.WriteLine("El numero menor es: " + menor);
        }
    }
}
