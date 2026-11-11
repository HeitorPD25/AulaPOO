using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IntroduçãoPOO
{
    internal class Onibus : Veiculo
    {

        public int Eixos { get; set; }

        public Onibus(string marca, string cor, int eixos) : base(marca, cor)
        {
            this.Eixos = eixos;
        }

        public override void Buzinar()
        {
            Console.WriteLine("Fom Fom");
        }

        public override double CalcularPedagio()
        {
            return base.CalcularPedagio() * Eixos;
        }

    }
}
