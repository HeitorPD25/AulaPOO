namespace IntroduçãoPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro("Fiat", "Vermelho");
            
            carro.Ligar();
            carro.Acelerar(10);
            carro.ExibirStatus();

        }
    }
}
