
namespace Loja_de_Bebidas
{
    public class Refrigerante : Bebida

    {
        public bool Vidro { get; set; }

        public void ImprimirRefrigerante(string Id, string NomeBebida, decimal Mililitro)
        {
            if (Vidro == true)
            {
                Console.WriteLine($"O produto {Id} com nome {NomeBebida} é um refrigerante com {Mililitro} ml é um vidro");
            }
            else
            {
                Console.WriteLine($"O produto {Id} com nome {NomeBebida} é um refrigerante com {Mililitro} é uma garrafa pet");
            }
        }
    }
}
