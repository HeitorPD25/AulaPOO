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
            Console.WriteLine("Construtor de Moto...");
        }

    }
}
