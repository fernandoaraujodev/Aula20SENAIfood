namespace Aula20SENAIfood
{
    public class Restaurante
    {
        public string NomeFantasia {get;set;}
        
        public string Endereco { get;set; }

        public void MostrarDados(){
           
            System.Console.WriteLine($"A {NomeFantasia} está localizada na {Endereco}\n");

        }

        public Restaurante( string _nomeFantasia, string _endereco ){
            
            this.NomeFantasia = _nomeFantasia;
            this.Endereco = _endereco;
            
        }
        


    }
}