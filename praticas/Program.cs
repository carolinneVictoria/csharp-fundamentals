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