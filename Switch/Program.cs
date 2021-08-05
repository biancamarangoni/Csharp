using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua nome!");
            string nome = Console.ReadLine();

            string letra = nome.Substring(0, 1);
        }
    }
}
