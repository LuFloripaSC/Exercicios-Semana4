using Loja_de_Bebidas;

bool manterMenuAberto = true;

while(manterMenuAberto)
{
    Menu.DisplayInicial();
    var opcao = Menu.DigiteOpcaoDesejada();
    switch (opcao)
    {
        case 1:
            Repositorio.AdicionarBebida();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 2:
            Repositorio.AlterarBebida();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 3:
            Repositorio.ExcluirBebida();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 4:
            Repositorio.ListarBebidas();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 5:
            Repositorio.ImprimirSuco();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 6:
            Repositorio.ImprimirRefrigerante();
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 7:
            Console.WriteLine("Até logo e Volte sempre!");
            manterMenuAberto = false;
            break;
        default:
            Console.WriteLine("Dados com erros, aguarde o display inicial");
            Thread.Sleep(5000);
            Menu.DisplayInicial();
            break;
    }
}

