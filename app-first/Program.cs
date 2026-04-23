Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void exibirMenu()
{
    Console.WriteLine("--------Boas Vindas--------");
    Console.WriteLine("1. Para registrar uma banda");
    Console.WriteLine("2. Para mostrar todas as bandas");
    Console.WriteLine("3. Para avaliar uma banda");
    Console.WriteLine("4. Para mostrar a média uma banda");
    Console.WriteLine("5. Para sair");

    Console.Write("Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoNumerica){
        case 1: registrarBanda();
            break;
        case 2: mostrarBandas();
            break;
        case 3: avaliarBanda();
            break;
        case 4: exibirMedia();
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
    bandasRegistradas.Add(nomeBanda, new List<int>());
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

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    exibirMenu();
}

void avaliarBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliar Banda.");
    //qual banda avaliar
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //essa banda existe?
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("A nota foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        exibirMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla prara voltar ao menu principal.");
        Console.ReadKey();
        exibirMenu();
        Console.Clear();
    }
}

void exibirMedia()
{
    Console.Clear();
    Console.WriteLine("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla prara voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        exibirMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla prara voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        exibirMenu();
    }
}

exibirMenu();