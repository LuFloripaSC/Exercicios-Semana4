namespace Loja_de_Bebidas
{
    static class Repositorio
    {
        private static List<Bebida> _bebida = new List<Bebida>();
        private static List<string> suco = new List<string>();
        private static List<string> refrigerante = new List<string>();

        public static object NomeBebida { get; private set; }

        public static void AdicionarSuco(string Suco)
        {
            suco.Add(Suco);
        }
        public static void AdicionarRefrigerante(string Refrigerante)
        {
            refrigerante.Add(Refrigerante);
        }
        public static void AdicionarBebida()
        {
            Console.WriteLine("Qual o ID da bebida que deseja adicionar?");
            int idBebidaNova = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome da bebida que deseja adicionar?");
            string bebidaNova = Console.ReadLine();
            Console.WriteLine("Quantos ml possui a bebida?");
            decimal mililitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da bebida?");
            decimal valorBebida = decimal.Parse(Console.ReadLine());

            Bebida bebida = new Bebida();
            bebida.Id = 1;
            bebida.Mililitro = mililitro;
            bebida.NomeBebida = bebidaNova;
            bebida.ValorCompra = valorBebida;
            _bebida.Add(bebida);
            Console.WriteLine("Bebida adicionada com sucesso! Pressione uma teclar para continuar...");
            Console.ReadLine();
        }
        internal static void AlterarBebida()
        {
            Console.WriteLine("Qual o nome da bebida que deseja alterar?");
            string bebidaAntiga = Console.ReadLine();

            Bebida index = _bebida.Find(x => x.NomeBebida == bebidaAntiga);
            if (index == null)
            {
                Console.WriteLine("Bebida não encontrada na lista!");
                return;
            }

            Console.WriteLine("Digite o novo nome da bebida:");
            string bebidaNova = Console.ReadLine();
            index.NomeBebida = bebidaNova;

            Console.WriteLine("Bebida alterada com sucesso!");
        }

        internal static void ExcluirBebida()
        {
            Console.WriteLine("Qual o nome da bebida que deseja excluir?");
            string bebidaExcluir = (Console.ReadLine());
            bool encontrou = false;
            foreach (var item in _bebida)
            {
                if (item.NomeBebida == bebidaExcluir)
                {
                    _bebida.Remove(item);
                    encontrou = true;
                    break;
                }
            }
            if(encontrou)
            {
                Console.WriteLine("Bebida excluída com sucesso.");
            }
             
            else
            {
                Console.WriteLine("Bebida não costa na lista!");
            }
                      
        }
        public static void ListarBebidas()
        {
            Console.WriteLine("Bebidas: ");
            foreach (Bebida Bebida in _bebida)
            {
                Console.WriteLine($"Id:{Bebida.Id} - Nome: {Bebida.NomeBebida} - Quantidade ml: {Bebida.Mililitro} - Preço R$: {Bebida.ValorCompra.ToString("N2")}");
            }
            Console.WriteLine("Acima estão as bebidas cadastradas no sistema! Pressione uma tecla para continuar... ");
            Console.ReadLine();
        }
        public static void ImprimirSuco()
        {
            Console.WriteLine("Sucos:");
            foreach (var nomeSuco in suco)
            {
                Console.WriteLine($"- {nomeSuco}:");
                foreach (var bebida in _bebida)
                {
                    if (bebida.NomeBebida == NomeBebida && bebida.NomeBebida.Contains(nomeSuco))
                    {
                        continue;
                    }
                        Console.WriteLine($"  - {bebida}");
                    
                }
            }
        }
        public static void ImprimirRefrigerante()
        {
            Console.WriteLine("Refrigerantes:");
            foreach (var nomeRefri in refrigerante)
            {
                Console.WriteLine($"- {nomeRefri}:");
                foreach (var bebida in _bebida)
                {
                    if (bebida.NomeBebida == NomeBebida && bebida.NomeBebida.Contains(nomeRefri))
                    {
                        continue;
                    }
                    Console.WriteLine($"  - {bebida}");
                }
            }
        }


    }
}
