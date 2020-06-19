using System;
namespace Aula20SENAIfood
{
    public class Pedido
    {
        public string Itens {get; set;}
        public Cliente cliente {get; set;}
        public string FormaDePGTO {get; set;}
        public bool PedidoPago {get; set;}         
        public Restaurante restaurante {get; set;}
        public DateTime HoraEntrega {get;set;}

        public Pedido(string _itens){  

            this.Itens = _itens;

        }

        public string EntregarPedido(){

            HoraEntrega = DateTime.Now;

            string Mensagem = $"\n{Itens} entregue as {HoraEntrega}\nPor: {restaurante.NomeFantasia} \nPara: {cliente.Nome} em {cliente.EnderecoAtual}";

            return Mensagem; 

        }


    }     
}     