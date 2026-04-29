using poo_csharp;

ContaBancaria contaBancaria= new ContaBancaria();
contaBancaria.NumeroIndicador = 12345;
contaBancaria.Titular = "João Silva";
contaBancaria.Saldo = 1000.50f;
contaBancaria.Senha = "senha123";
contaBancaria.exibirDados();
