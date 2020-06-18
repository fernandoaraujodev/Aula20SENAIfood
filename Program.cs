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

            Pedido pedido = new Pedido("Feijoada", "Gil" );
            
        }                
    }
}