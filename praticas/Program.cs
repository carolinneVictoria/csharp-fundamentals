// Calculando a idade
Console.Write("Digite seu ano de nascimento: ");
string anoNascimento = Console.ReadLine()!;
int anoConvertido = int.Parse(anoNascimento);

int calculo = 2026 - anoConvertido;
Console.WriteLine($"Sua idade é {calculo}");
