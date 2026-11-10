using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduçãoPOO
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        
        public int Velocidade { get; private set; }

        public bool Ligado { get; set; }

        public Carro (string marca, string cor)
        {
            this.Marca = marca;
            this.Cor = cor;
        } 

        public void Ligar()
        {
            ligado = true;
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

        public bool EstaParado()
        {
            return Velocidade == 0;
        }

        public string ObterDescricao()
        { 
            return $"{Marca} {Cor}";
        }

    }
}
