using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2;

        Console.WriteLine("Ingrese dos numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        
        if(n1 < n2){
            Console.WriteLine("El numero más bajo es: " + n1);
        }else{
            Console.WriteLine("El numero más bajo es: " + n2);
        }

        }
    }
}
