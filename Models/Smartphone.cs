using DesafioPOO.Interfaces;

namespace DesafioPOO.Models
{
    public abstract class Smartphone : IServico
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        
        public Smartphone()
        {            
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        
        /*
            Os métodos Ligar e ReceberLigação foram retirados da classe Smartphone e
            foi criado uma interface com impplentação dentro dos mesmos e chamados
            dentro da classe Smartphone, conforme foi falado durante o curso. O objetivo
            foi o reuso, e poluir menos a classe Smartphone, logo isso me fez lembrar 
            o Princípio da responsabilidade única do SOLID, a ideia partiu daí. O nome da interface é IServico
        */


        public abstract void InstalarAplicativo(string nomeApp);
    }
}