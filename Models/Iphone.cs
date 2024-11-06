namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modeloConstrutor, string imeiConstrutor, int memoriaConstrutor) : base(numero, modeloConstrutor, imeiConstrutor, memoriaConstrutor)
        {
        }


        // TODO: Sobrescrever o método "InstalarAplicativo"


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Iphone");
        }
    }
}