using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1;

        Console.WriteLine("Ingrese un numero para saber si el mismo es positivo o negativo:");
        n1 = int.Parse(Console.ReadLine());

        if(n1 > 0){
            Console.WriteLine("Positivo");
        }else{
            if(n1 == 0){
                Console.WriteLine("Cero");
            }else{
                Console.WriteLine("Negativo");
            }
        }
        }
    }
}
