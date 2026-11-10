using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduçãoPOO
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Velocidade { get; private set; }
        public bool Ligado { get; set; }
        protected int combustivel = 50;

        public Veiculo(string marca, string cor)
        {
            this.Marca = marca;
            this.Cor = cor;
            Console.WriteLine("Construtor de Veículos...");
        }

        public void Ligar()
        {
            Ligado = true;
        }

        public void Acelerar(int qtd)
        {
            Velocidade += qtd;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"{Marca} {Cor} a {Velocidade} km/h");
            // Console.WriteLine($"Ligado: {ligado}");
            if (Ligado == true)
            {
                Console.WriteLine("Ligado...");
            }
            else
            {
                Console.WriteLine("Desligado...");
            }

        }
    }
}
