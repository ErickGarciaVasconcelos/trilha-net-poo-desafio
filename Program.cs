using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma instância de Iphone
            Iphone meuIphone = new Iphone("123456789", "iPhone X", "IMEI123", 64);

            // Criar uma instância de Nokia
            Nokia meuNokia = new Nokia("987654321", "Nokia 3310", "IMEI987", 16);

            // Chamar métodos ou acessar propriedades, se necessário
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("WhatsApp");

            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("Snake");

            // Pausar a execução para ver as saídas
            Console.ReadLine();
        }
    }
}

