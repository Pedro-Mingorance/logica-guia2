using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1;

        Console.WriteLine("Ingrese un numero para saber si es par o inmpar:");
        n1 = int.Parse(Console.ReadLine());

        n1 = n1 % 2;
        if(n1 == 0){
            Console.WriteLine("Par");
        }else{
            Console.WriteLine("Inmpar");
        }
        }
    }
}
