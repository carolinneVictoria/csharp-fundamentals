namespace poo_csharp;

public class ContaBancaria
{
    public ContaBancaria(string Titular)
    {
        Titular = Titular.Trim();
    }
    public int NumeroIndicador { get; set; }
    public string Titular { get; }
    public float Saldo { get; set; }
    public string Senha { get; set; }

    public void exibirDados()
    {
        Console.WriteLine($"Número do Indicador: {NumeroIndicador}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}
