using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2;

        Console.WriteLine("Ingrese dos numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        if(n1 != n2){
            if(n1 > n2){
                Console.WriteLine("El numero mayor es: " + n1);
            }else{
                Console.WriteLine("El numero mayor es: " + n2);
            }
        }else{
            Console.WriteLine("Los numeros son iguales");
        }


        }
    }
}
