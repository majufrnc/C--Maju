using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasses.src
{
    public class Prato
    {
        public Salada Salada { get; set; }
        public Carboidrato Carboidrato { get; set; }
        public Proteina Proteina { get; set; }

        public Prato()
        {

        }

        public Prato(Salada salada, Carboidrato carboidrato, Proteina proteina)
        {
            Salada = salada;
            Carboidrato = carboidrato;
            Proteina = proteina;
        }
        public override string ToString()
        {
            return $"O prato foi: {Salada}, {Carboidrato} e {Proteina}.";
        }
    }
    public enum Salada
    {
        Tomate, Rúcula, Cenoura, Alface, Couve
    }
    public enum Carboidrato
    {
        Arroz, Macarrão, Quinoa
    }
    public enum Proteina
    {
        Carne, Frango, Ovo
    }

}