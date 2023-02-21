using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, n3, n4, n5, menor, mayor;

        Console.WriteLine("Ingrese 5 numeros separados por la tecla enter: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        n3 = int.Parse(Console.ReadLine());
        n4 = int.Parse(Console.ReadLine());
        n5 = int.Parse(Console.ReadLine());

        if(n1 > n2)
            mayor = n1;
        else
            mayor = n2;

        if(n3 > mayor)
            mayor = n3;

        if(n4 > mayor)
            mayor = n4;
        
        if(n5 > mayor)
            mayor = n5;
        

        if(n1 < n2)
            menor = n1;
        else
            menor = n2;
        
        if(n3 < menor)
            menor = n4;
        
        if(n5 < menor)
            menor = n5;
        
        if(n3 < menor)
            menor = n3;
        
        Console.WriteLine("El numero menor es: " + menor + " y el numero mayor es: " + mayor);
        }
    }
}
