namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo) : base(numero, modelo)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Você instalou o aplicativo {nomeApp} no seu Iphone");
        }
    }
}