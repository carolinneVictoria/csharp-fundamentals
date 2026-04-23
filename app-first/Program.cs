List<string> listaBandas = new List<string>{"Metallica", "U2", "The Beatles"};

void exibirMenu()
{
    Console.WriteLine("--------Boas Vindas--------");
    Console.WriteLine("1. Para registrar uma banda");
    Console.WriteLine("1. Para mostrar todas as bandas");
    Console.WriteLine("1. Para avaliar uma banda");
    Console.WriteLine("1. Para mostrar a média uma banda");
    Console.WriteLine("5. Para sair");

    Console.Write("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoNumerica){
        case 1: registrarBanda();
            break;
        case 2: mostrarBandas();
            break;
        case 3: Console.WriteLine("Voce escolheu a opcao " + opcaoNumerica);
            break;
        case 4: Console.WriteLine("Voce escolheu a opcao " + opcaoNumerica);
            break;
        case 5: Console.WriteLine("Voce escolheu sair.");
            break;
        default: Console.WriteLine("Digite uma opção valida!");
            break;
    }
}

void registrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas.");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirMenu();
}

void mostrarBandas()
{
    Console.Clear();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Exibindo todas as bandas registradas: \n");
    for(int i=0; i < listaBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    exibirMenu();
}

exibirMenu();
