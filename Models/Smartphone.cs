namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        //propriedades
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Mei {get; set;}
        private int Memoria {get; set;}
        //constructor 
        public Smartphone(string numero, string modelo)
        {
            Numero = numero;
            Modelo = modelo;

    
        }
        //metodos
        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para...{numero}");
        }

        public void ReceberLigacao(string numero, string modelo)
        {
                
            Console.WriteLine($"Recebendo ligação do numero ... {numero} modelo {modelo}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}