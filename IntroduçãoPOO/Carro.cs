using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduçãoPOO
{
    internal class Carro
    {
        public string marca = "Marca Desconhecida";
        public string cor = "Cor Desconhecida";
        public int velocidade;
        public bool ligado;

        public Carro (string marca, string cor)
        {
            this.marca = marca;
            this.cor = cor;
        } 


        public void Ligar()
        {
            ligado = true;
        }

        public void Acelerar(int qtd)
        {
            velocidade += qtd;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"{marca} {cor} a {velocidade} km/h");
            // Console.WriteLine($"Ligado: {ligado}");
            if (ligado == true)
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
            return velocidade == 0;
        }

        public string ObterDescricao()
        { 
            return $"{marca} {cor}";
        }

    }
}
