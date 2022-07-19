using System;
using ExercicioClasses.src;

namespace ExercicioClasses.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prato _boaz = new Prato(Salada.Rúcula,Carboidrato.Arroz,Proteina.Carne);
            Prato _maju = new Prato(Salada.Tomate, Carboidrato.Macarrão, Proteina.Frango);
            Console.WriteLine(_boaz.ToString());
            Console.WriteLine(_maju.ToString());
        }
    }
}
