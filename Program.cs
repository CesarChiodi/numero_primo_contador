using System;

namespace numero_primo_contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i, cont = 0;
            Console.WriteLine("escolha um numero");
            numero = int.Parse(Console.ReadLine());
            for(i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    cont++;
                }               
            }
            if (cont == 2)
            {
                Console.WriteLine("o numero {0} é primo", numero);
            }
            else
            {
                Console.WriteLine("o numero {0} nao é primo", numero);
            }
            Console.ReadKey(); 
        }
    }
}
    