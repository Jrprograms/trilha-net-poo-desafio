namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }  
    

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if (string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(imei) || memoria <= 0)
            {
                throw new ArgumentException("Parâmetros inválidos para criar um Smartphone.");
            }

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
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