using System;

namespace CalculadoraMallu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vinde a calculadora da Mallu!\nVamos começar?");

            int continuar = 1;
            do
            {

                Console.WriteLine("Qual operação seguiremos agora?");
                Console.WriteLine($"1- Somar;\n" +
                    $"2- Subtrair;\n" +
                    $"3- Multiplicar;\n" +
                    $"4- Dividir;");
                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("Digite o 1º valor: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2º valor: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int resultado = Somar(a, b);

                    Console.WriteLine("O valor da operação é: " + resultado);

                }
                if (escolha == 2)
                {
                    Console.WriteLine("Digite o 1º valor: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2º valor: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int resultado = Subtrair(a, b);

                    Console.WriteLine("O valor da operação é: " + resultado);

                }
                if (escolha == 3)
                {
                    Console.WriteLine("Digite o 1º valor: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2º valor: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    int resultado = Multiplicar(a, b);

                    Console.WriteLine("O valor da operação é: " + resultado);

                }
                if (escolha == 4)
                {
                    Console.WriteLine("Digite o 1º valor: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o 2º valor: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 0)
                    {
                        Console.WriteLine("ERRO! Operação inválida! \nNa matemática, não podemos dividir números por 0!\n");
                        continue;
                    }

                    int resultado = Dividir(a, b);


                    
                   Console.WriteLine("O valor da operação é: " + resultado);

                }

                Console.WriteLine("Quer continuar? Digite 1 para SIM e 0 para NÃO!: ");
                int v = Convert.ToInt32(Console.ReadLine());
                continuar = v;
                Console.Clear();

            } while (continuar == 1);

            static int Somar(int a, int b)
            {
                return a + b;
            }
            static int Subtrair(int a, int b)
            {
                return a - b;
            }
            static int Multiplicar(int a, int b)
            {
                return a * b;
            }
            static int Dividir(int dividendo, int divisor)
            {
                return dividendo / divisor;
             
            }   
        }   
    } 
}