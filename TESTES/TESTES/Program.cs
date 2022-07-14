using System;

namespace IMCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coloque seu peso, por favor: ");

            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque sua altura, por favor: ");

            float altura = (float)Convert.ToDouble(Console.ReadLine());
            float imc = (peso / (altura * altura));

            Console.WriteLine("Seu peso: " + peso+"\n");
            Console.WriteLine("Sua altura: " + altura +"\n");
            Console.WriteLine("Seu IMC é: " + imc + "\n");
            Console.WriteLine($"As opções são: \n" +
                $"- Abaixo do peso;\n" +
                $"- Dentro do peso normal;\n" +
                $"- Com sobrepeso;\n" +
                $"- Com obesidade.\n");

            if (imc <= 18.5)
            {
                Console.WriteLine("Você está: abaixo do peso.");
            }
            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine("Você está: dentro do peso normal.");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Você está: com sobrepeso.");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Você está: com obesidade.");
            }
        }
    }
}