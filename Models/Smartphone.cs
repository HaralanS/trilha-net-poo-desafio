namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string modelo;
        protected string imei;
        protected int memoria;
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modeloConstrutor, string imeiConstrutor, int memoriaConstrutor)
        {
            Numero = numero;
            modelo = modeloConstrutor;
            imei = imeiConstrutor;
            memoria = memoriaConstrutor;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}