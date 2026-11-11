namespace IntroduçãoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Veiculo veiculo = new Veiculo("Genérico", "Cinza");
            //veiculo.Buzinar();

            Carro carro = new Carro("Fiat", "Vermelho", 4);
            
            Moto moto = new Moto("Honda", "Preto", false);

            Onibus busao = new Onibus("Mercedes", "Amarelo", 3);

            Veiculo[] garagem = { carro, moto, busao };

            foreach (Veiculo veiculo in garagem)
            {
                veiculo.Buzinar();
                Console.WriteLine($"Pedágio: R${veiculo.CalcularPedagio():F2}");
            }


          
        }
    }
}
