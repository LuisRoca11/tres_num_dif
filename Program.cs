// Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10, 
// imprimir en pantalla la leyenda "Alguno de los números es menor a diez".

using System;
using System.Collections.Specialized;


namespace tres_num_dif
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Incresar numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Incresar numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Incresar numero 3: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1<10 || num2<10 || num3<10)
            {
                Console.WriteLine("Alguno de los números es menor a diez");
            }

            Console.ReadKey();
        }
    }
}