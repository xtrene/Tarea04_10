using System;

namespace Tarea04_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Números pares o divisibles entre 3 del 1 al 100: ");
            while (num < 100)
            {
                num++;
                if (num % 2 == 0 || num%3 == 0)
                {
                    Console.Write(" " + num);
                }

            }



            Console.ReadKey();
        }
    }
}
