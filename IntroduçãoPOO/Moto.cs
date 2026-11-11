using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduçãoPOO
{
    internal class Moto : Veiculo
    {
        public bool temBau;
        public Moto(string marca, string cor, bool temBau) : base(marca, cor)
        {
            this.temBau = temBau;
        }

        public override void Buzinar()
        {
            Console.WriteLine("Bi-bi!");
        }

        public override double CalcularPedagio()
        {
            return 5;
        }

    }
}
