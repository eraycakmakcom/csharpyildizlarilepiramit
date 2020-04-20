using System;

namespace yildiz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int yil = 1; yil < 20; yil += 2)
            {
                for (int diz = 0; diz < 9 - yil / 2; diz++)
                    Console.Write(" ");

                for (int diz = 0; diz < yil; diz++)
                    Console.Write("*");

                Console.WriteLine();
            }

           

            Console.ReadKey();
        }
    }
}