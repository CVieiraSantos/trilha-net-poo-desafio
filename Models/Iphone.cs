using System.Text;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone()
        {            
        }

        public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApplicativo)
        {
            Console.WriteLine($"Instalando aplicatico: {nomeApplicativo.ToUpper()} no iPhone");
        }
       
    }
}