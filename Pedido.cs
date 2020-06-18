using System;
namespace Aula20SENAIfood
{
    public class Pedido
    {
        public string Itens {get; set;}
        public string Cliente {get; set;}
        public string FormaDePGTO {get; set;}
        public bool PedidoPago {get; set;}         
        public string Restaurante {get; set;}

        public Pedido(string _itens, string _cliente){  

            this.Itens = _itens;
            this.Cliente = _cliente;

        }

        public string EntregarPedido(){
            return "O pedido saiu para entrega....";
        }


    }     
}     