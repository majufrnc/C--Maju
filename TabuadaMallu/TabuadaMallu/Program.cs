using System;

namespace TabuadaMallu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vinde a Tabuada da Mallu!\n"+"Digita a tabuada de sua preferência: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(numero +" x "+i+" = "+numero * i + "\n");
            }
        }
    }
}
