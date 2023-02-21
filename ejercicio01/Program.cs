using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1;

        Console.WriteLine("Ingrese un numero:");
        n1 = int.Parse(Console.ReadLine());

        if(n1 > 10){
            Console.WriteLine("El numero es mayor a 10");
        }
        else{
            Console.WriteLine("El numero es menor o igual a 10");
        }
        
        }
    }
}
