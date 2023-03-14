
namespace Loja_de_Bebidas
{
    public class Suco : Bebida

    {
        public string TipoCaixa { get; set; }

        public void ImprimirSuco(string Id, string TipoCaixa, decimal Mililitro)
        {
            Console.WriteLine($"O produto {Id}, é um suco é do tipo {TipoCaixa}, com a quantidade de {Mililitro}.");
        }
          
    } 
}
