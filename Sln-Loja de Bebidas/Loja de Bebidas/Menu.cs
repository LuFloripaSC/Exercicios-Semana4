
namespace Loja_de_Bebidas
{
    public static class Menu
    {
        public static void DisplayInicial()
        {
            Console.Clear(); // Método que vai limpar os dados em tel
            Console.WriteLine("\n"); // Quebra de linha com o \n e WriteLine
            Console.WriteLine("Loja de Bebidas"); // Título do Console
            Console.WriteLine("***************************************");// Corte da linha
            Console.WriteLine("\n"); // Quebra de linha com o \n e WriteLine
        }

        // <summary>
        // Função que vai retornar o valor digitado na tela
        // <returns>Inteiro</returns>

        public static int DigiteOpcaoDesejada() 
        { 
            try
            {   
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1- Inserir Bebida");
                Console.WriteLine("2- Alterar Bebida");
                Console.WriteLine("3- Excluir Bebida");
                Console.WriteLine("4- Listar todas as Bebidas");
                Console.WriteLine("5- Listar todos os Sucos");
                Console.WriteLine("6- Listar todos os Refrigerantes");
                Console.WriteLine("7- Sair");
                Console.WriteLine("\n");

                Console.WriteLine("Opção :");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opção com erro, selecione a opção correta");
                Console.ReadLine();
            }
            return DigiteOpcaoDesejada();
        }

        public static bool ReiniciarDisplayConsole()
        {
            Console.WriteLine("\n");
            Console.WriteLine("***************************************");
            Console.WriteLine("Deseja reiniciar o menu");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.WriteLine("\n");

            Console.WriteLine("Opção :");

            if(Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.DisplayInicial();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
