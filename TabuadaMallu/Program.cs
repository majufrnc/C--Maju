using System;

namespace TabuadaMallu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vinde a Tabuada da Mallu!\n");
            int decisao = 1;
            do
            {
                Console.WriteLine("Digite a tabuada de sua preferência: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + numero * i + "\n");
                }

                Console.WriteLine("Quer continuar? Se sim, digite 1. Se não, digite 0.");
                decisao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (decisao == 1);
        }
    }
}
