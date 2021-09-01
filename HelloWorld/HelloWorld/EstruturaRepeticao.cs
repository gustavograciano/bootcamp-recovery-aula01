using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class EstruturaRepeticao
    {
        static void Main(string[] argumentos)
        {

            Console.WriteLine("\n FOR \n");

            for (var loop = 0; loop<10; loop++)
            {
                var argumento = argumentos[loop];

                Console.WriteLine($"Argumento lido:{argumento}");

            }

            Console.WriteLine("\n FOREACH \n");

            foreach (var argumento in argumentos)
            {
                Console.WriteLine($"Argumento lido:{argumento}");
            }


            Console.WriteLine("\n WHILE \n");

            var loop2 = 0;
                while (loop2 < argumentos.Length)
            {
                var argumento = argumentos[loop2];
                Console.WriteLine($"Argumento lido:{argumento}");
                loop2++;
            }

            Console.WriteLine("\n DO WHILE \n");

            var loop3 = 0;
            do
            {
                var argumento = argumentos[loop3];
                Console.WriteLine($"Argumento lido:{argumento}");
                loop3++;
            } while (loop3 < argumentos.Length);

        }

    }
}
