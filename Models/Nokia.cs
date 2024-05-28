namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo) : base(numero, modelo)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"instalando o App {nomeApp}");
        }
    }
}