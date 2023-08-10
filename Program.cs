using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mais uma linha!");

            string nome = "Maria José";

            Console.WriteLine("O nome da pessoa é " + nome);

            Console.Write("Entre com um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O número digitado foi: " + numero);
            
            Console.ReadKey();
        }
    }
}
