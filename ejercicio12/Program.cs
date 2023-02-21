using System;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1;

        Console.WriteLine("Ingrese un numero");
        n1 = int.Parse(Console.ReadLine());

        if(n1 > 60){
            n1 = n1 / 60;
            Console.WriteLine(n1 + " hora/s");
        }else{
            Console.WriteLine(n1 + " minutos");
        }

        }
    }
}
