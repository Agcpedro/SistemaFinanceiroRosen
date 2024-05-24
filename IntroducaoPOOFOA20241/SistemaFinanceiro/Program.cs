// See https://aka.ms/new-console-template for more information
using SistemaFinanceiro.Model;
//Slide 26 -  Criação de uma Nova Conta

var operacao = new Operacao();

var conta1 = new Conta(123, 1000m);

var conta2 = new Conta(654321, 2341.42m);

var cliente1 = new Cliente("Pedro", 20, "12345678901", conta1);

Console.WriteLine($"O saldo da conta1{conta1.Numero} é {conta1.Saldo}");
Console.WriteLine($"O saldo da conta{conta2.Numero} é {conta2.Saldo}");

//Slide 26 -  O numero que possui maior saldo

var maiorSaldo = operacao.CamparaMaiorSaldo(conta1, conta2);

Console.WriteLine($"O conta com maior saldo é {maiorSaldo}");

//Slide 26 -  Saldo Total Geral (Intendi que é o saldo de todas as contas)

var totalSaldo = (conta1.Saldo + conta2.Saldo);

Console.WriteLine($"O Saldo Total Geral é {totalSaldo}");

//Slide 26 - Vinculando Conta ao Cliente

Console.WriteLine($"A conta do {cliente1.Nome} é {cliente1.Conta.Numero}");

//Slide 30 - Criar uma Conta com  mais de R$10

Console.WriteLine("Digite o numero da conta:");
long numeroConta = Convert.ToInt64(Console.ReadLine());


Console.WriteLine("Digite o saldo da conta:");
decimal numeroSaldo = Convert.ToDecimal(Console.ReadLine());

var conta3 = new Conta(numeroConta, numeroSaldo);

Console.WriteLine($"Conta nova Criada, Numero:{conta3.Numero} Saldo:{conta3.Saldo}");











