namespace Aula20SENAIfood
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string EnderecoAtual {get; set;}

        public Cliente(string _nome, string _enderecoAtual){
             
            this.Nome = _nome;
            this.EnderecoAtual = _enderecoAtual; 

        }

        public void MostrarDados(){

            System.Console.WriteLine($"O Sr {Nome} está localizada em {EnderecoAtual}\n");

        }
    
        
    } 
}