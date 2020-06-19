using System;

namespace Aula20SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante bar = new Restaurante("Cantina do Zé", "Estrada Nova Ipe nº1028");
            bar.MostrarDados();

            Cliente pessoa = new Cliente("Carlos", "Avenida Paranapanema nº1343"); 
            pessoa.MostrarDados();

            Pedido pedido = new Pedido("Feijoada com farofa");
            pedido.cliente = pessoa;   //passando atributo (Nome) da classe Cliente para atributo Cliente da classe Pedido
            pedido.restaurante = bar;  //os 2 sem herança

            System.Console.WriteLine("\nVocê já pagou seu pedido no valor de R$15?");
            pedido.PedidoPago = Boolean.Parse(Console.ReadLine());
            
            
            if (pedido.PedidoPago == true){

            System.Console.WriteLine($"\nSeu pedido está a caminho!");

            System.Console.WriteLine(pedido.EntregarPedido());
            
            }else{

                System.Console.WriteLine("\nPague no local");
            }

            
        }                
    }
}