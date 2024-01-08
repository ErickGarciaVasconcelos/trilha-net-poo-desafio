using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int Memoria) : base(numero, modelo, imei, Memoria)
        {
            Console.WriteLine($"Seu número de Imei é {IMEI}");
            Console.WriteLine($"Seu número de telefone é {numero}");
            Console.WriteLine($"Sua memória interna é {Memória}");
            Console.WriteLine($"O modelo do seu celular é {Modelo}");
            
        }
    }   
}