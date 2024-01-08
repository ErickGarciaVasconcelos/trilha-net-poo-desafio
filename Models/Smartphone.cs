using System.Dynamic;

namespace DesafioPOO.Models
{
    public abstract class Smartphone 
    {
        public string Modelo { get; set; }
         public string IMEI { get; set; }
         public int Memória { get; set; }
        public string Numero { get; set; }
        
        // Implementado
         

        public Smartphone(string numero, string modelo, string Imei, int Memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = Imei;
            Memória = Memoria;
            // Implementado
        }

        public void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
    }
}