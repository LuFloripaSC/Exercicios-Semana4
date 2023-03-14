using Loja_de_Bebidas;

Menu.DisplayInicial();
Menu.DigiteOpcaoDesejada();

bool manterMenuAberto = true;

while(manterMenuAberto)
{
    Menu.DisplayInicial();
    var opcao = Menu.DigiteOpcaoDesejada();
    switch (opcao)
    {
        case 1:
            Bebida bebida = new Bebida();
            bebida.Id = 1;
            bebida.Mililitro = 350;
            bebida.NomeBebida = "Cerveja";
            bebida.ValorCompra = 5;
            Repositorio.AdicionarBebida(bebida);
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 2:
            Bebida bebida1 = new Bebida();
            bebida1.Id = 2;
            bebida1.Mililitro = 500;
            bebida1.NomeBebida = "Refrigerante";
            bebida1.ValorCompra = 10;
            Repositorio.AlterarBebida(bebida1);
            manterMenuAberto = Menu.ReiniciarDisplayConsole();
            break;

        case 3:
            Bebida bebida2 = new Bebida();
            bebida2.Id = 1;
            bebida2.Mililitro = 200;
            bebida2.NomeBebida = "Suco";
            bebida2.ValorCompra = 2;
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

