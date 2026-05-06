using poo_csharp;

ContaBancaria contaBancaria= new ContaBancaria("João Silva");

contaBancaria.NumeroIndicador = 12345;
contaBancaria.Saldo = 1000.50f;
contaBancaria.Senha = "senha123";

contaBancaria.exibirDados();
