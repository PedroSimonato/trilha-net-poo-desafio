namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" OK
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" OK
    }
}