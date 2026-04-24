// Calculando a idade
Console.Write("Digite seu ano de nascimento: ");
string anoNascimento = Console.ReadLine()!;
int anoConvertido = int.Parse(anoNascimento);

int calculo = 2026 - anoConvertido;
Console.WriteLine($"Sua idade é {calculo}");

// Registro de doações
float valorRecebido = 500.00f;
bool doacaoAnonima = true;
char tipoConta = 'P';

Console.WriteLine("Valor recebido: R$" + valorRecebido);
Console.WriteLine("Doação anônima: " + doacaoAnonima);
Console.WriteLine("Tipo de conta: " + tipoConta);

// Milhas em quilometros
double distancia = 10.0;
double milhasConvert = distancia * 1.60934;

Console.WriteLine($"{distancia} milhas são equivalentes a {milhasConvert} quilômetros!");

//Convertendo horas para minutos
int minutos = 250;
int horas = minutos / 60;
int restantesMinutos = minutos % 60;

Console.WriteLine("Tempo: " + horas + " horas e " + restantesMinutos + " minutos");

