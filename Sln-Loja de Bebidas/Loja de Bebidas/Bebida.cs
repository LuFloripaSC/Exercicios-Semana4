
namespace Loja_de_Bebidas
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Refrigerante { get; set; }

        public string Suco { get; set; }
        public decimal Mililitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }

        public void Comprar(int Id, decimal ValorCompra)
        {
            Console.WriteLine($"Valor de compra do produto: {Id} alterado para {ValorCompra}");
        }
    }
}
