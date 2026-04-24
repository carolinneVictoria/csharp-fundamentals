// Calculando a idade
Console.Write("Digite seu ano de nascimento: ");
string anoNascimento = Console.ReadLine()!;
int anoConvertido = int.Parse(anoNascimento);

int calculo = 2026 - anoConvertido;
Console.WriteLine($"Sua idade é {calculo}\n");

// Registro de doações
float valorRecebido = 500.00f;
bool doacaoAnonima = true;
char tipoConta = 'P';

Console.WriteLine("Valor recebido: R$" + valorRecebido);
Console.WriteLine("Doação anônima: " + doacaoAnonima);
Console.WriteLine("Tipo de conta: " + tipoConta + "\n");

// Milhas em quilometros
double distancia = 10.0;
double milhasConvert = distancia * 1.60934;

Console.WriteLine($"{distancia} milhas são equivalentes a {milhasConvert} quilômetros!\n");

//Convertendo horas para minutos
int minutos = 250;
int horas = minutos / 60;
int restantesMinutos = minutos % 60;

Console.WriteLine("Tempo: " + horas + " horas e " + restantesMinutos + " minutos. \n");

// Area do retangulo
double largura = 10.5;
double comprimento = 20.3;
double calculoArea = largura * comprimento;

Console.WriteLine($"A area do retangulo é {calculoArea} metros! \n");

// Soma das vendas
int valor, total = 0;
do
{
    Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
    valor = int.Parse(Console.ReadLine()!);
    total += valor;
} while (valor != 0);
Console.WriteLine("Total de vendas do dia: R$" + total);

// Produtos no estoque
int estoque = 0;
Console.WriteLine("Deseja adicionar um produto ao estoque?");
Console.WriteLine("1 - Sim | 0 - Não");
int resposta = int.Parse(Console.ReadLine()!);

while (resposta == 1)
{
    Console.WriteLine("Quantidade:");
    int quantidade = Convert.ToInt32(Console.ReadLine());
    estoque += quantidade;

    Console.WriteLine($"Estoque atual: {estoque}");

    Console.WriteLine("Deseja continuar?");
    Console.WriteLine("1 - Sim | 0 - Não");
    resposta = int.Parse(Console.ReadLine()!);
}
;

// Classificação de números
List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

for (int i = 0; i < notas.Count; i++)
{
    if (notas[i] >= 6)
    {
        Console.WriteLine($"Nota {notas[i]} - Aprovado");
    }
    else
    {
        Console.WriteLine($"Nota {notas[i]} - Reprovado");
    }
}

// O laço certo
List<double> notas1 = new List<double>
{
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
};

double mediaCorte = 7.0;

foreach (var nota in notas1)
{
    if (nota < mediaCorte)
    {
        Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
    }

    else
    {
        Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
    }
}

// Quantos impares digitados
int qtdImpares = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    if (numero % 2 != 0)
    {
        qtdImpares++;
    }
}
Console.WriteLine($"Você digitou {qtdImpares} números ímpares.");