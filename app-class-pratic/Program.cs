public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set;}

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void exibirFicha()
    {
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }
}
public class Passagem
{
    public string Passageiro { get; set; }
    public string Destino { get; set; }

    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }
    public void exibirFicha()
    {
        Console.WriteLine("Passageiro: " + Passageiro);
        Console.WriteLine("Destino: " + Destino);
    }
}
public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public void depositar (double valor)
    {
        Saldo += valor;
    }
    public void exibirFicha()
    {
        Console.WriteLine("Numero da Conta: " + NumeroConta);
        Console.WriteLine("Saldo Atual: " + Saldo);
    }
}
public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public Funcionario (string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }
    public void promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        {
            Console.WriteLine("Promoção realizada com sucesso!");
            Console.WriteLine("--- Após promoção ---");
            Console.WriteLine("Funcionário: " + Nome);
            Console.WriteLine("Cargo Atual: " + novoCargo);
        } else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
    }
}
public class Retangulo
{
    public int Altura { get; set; }
    public int Largura { get; set; }

    public Retangulo(int altura, int largura)
    {
        Altura = altura;
        Largura = largura;
    }
    public double areaRetangulo()
    {
        return Largura * Altura;
    }
}

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro("O morro dos ventos uivantes", "Emily Bronte");
        livro1.exibirFicha();

        Passagem passagem1 = new Passagem("Carolinne", "Curitiba");
        passagem1.exibirFicha();

        ContaBancaria contaBancaria1 = new ContaBancaria();
        contaBancaria1.NumeroConta = "1234-5";
        contaBancaria1.Saldo = 1000.0;
        contaBancaria1.depositar(500.0);
        contaBancaria1.exibirFicha();

        Funcionario novoFuncionario = new Funcionario("Carolinne", "Desenvolvedora Jr.");
        novoFuncionario.promover("Desenvolvedora Senior");

        Retangulo retangulo1 = new Retangulo(5,8);
        Console.WriteLine("Area do Retangulo: " + retangulo1.areaRetangulo());
    }
}

