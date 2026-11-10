using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduçãoPOO
{
    internal class Carro : Veiculo
    {

        public int portas;

        public Carro(string marca, string cor, int portas) : base(marca, cor)
        {
            this.portas = portas;
            Console.WriteLine("Construtor de Carros...");
        }

        public void Abastecer(int litros)
        {
            combustivel += litros;
        }

    }
}
