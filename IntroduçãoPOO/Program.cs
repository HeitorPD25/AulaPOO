namespace IntroduçãoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carro carro1 = new Carro();
            //carro1.marca = "Fiat";
            //carro1.cor = "Vermelho";
            //carro1.velocidade = 0;

            //Carro carro2 = new Carro();
            //carro2.marca = "Honda";
            //carro2.cor = "Preto";
            //carro2.velocidade = 40;

            // Console.WriteLine($"O carro {carro1.marca} {carro1.cor} estava a {carro1.velocidade}Km/h.");
            // Console.WriteLine($"O carro {carro2.marca} {carro2.cor} estava a {carro2.velocidade}Km/h.");

            //Carro carro = new Carro();
            //Console.WriteLine($"Velocidade: {carro.velocidade}");
            //Console.WriteLine($"Ligado: {carro.ligado}");
            //Console.WriteLine($"Marca: {carro.marca}");

            //Carro carro = new Carro();
            //carro.marca = "Fiat";
            //carro.cor = "Vermelho";
            //// Velocidade = 0 km/h
            //// Ligado = false

            //carro.Ligar();
            //carro.Acelerar(30);
            //carro.ExibirStatus();

            //bool estaParado = carro.EstaParado();
            //Console.WriteLine($"Está parado? {estaParado}");

            //string descricao = carro.ObterDescricao();
            //Console.WriteLine(descricao);

            Carro carro1 = new Carro("Fiat", "Vermelho");
            carro1.ExibirStatus();

        }
    }
}
