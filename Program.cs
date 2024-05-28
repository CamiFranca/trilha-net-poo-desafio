using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

public class Program
{
    public static void Main()
    {
        Nokia cell = new Nokia(numero: "97859647", modelo:"s10");

        cell.InstalarAplicativo("whatsapp");
        cell.Ligar("94856931");
        cell.ReceberLigacao("49563214", "s10");
       
        Console.WriteLine("----------------------------------------------");

        Iphone phone = new Iphone("93657892","I13");

        phone.InstalarAplicativo("tinder");
        phone.Ligar("56987413");
        phone.ReceberLigacao("7896541", "I13");


    }
}
 