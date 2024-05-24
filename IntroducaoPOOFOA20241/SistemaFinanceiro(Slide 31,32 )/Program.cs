// See https://aka.ms/new-console-template for more information
using SistemaFinanceiro.Model;
using SistemaFinanceiro_Slide_31_32__.Model;

var operação = new Operacao();

Console.WriteLine("Primeiro Crie um Banco:");

Banco banco = operação.CriarBanco();

Console.WriteLine("Agora crie uma Agencia que pertence a esse banco:");

Agencia agencia = operação.CriarAgencia(banco);


//Slide 31 - Criar Conta

Console.WriteLine("Digite o numero da conta:");
long numeroConta = Convert.ToInt64(Console.ReadLine());


Console.WriteLine("Digite o saldo da conta:");
decimal numeroSaldo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora Crie um Cliente para associar a Conta:");

Cliente cliente = operação.CriarCliente();

var conta = new Conta(numeroConta, numeroSaldo, cliente, agencia);

Console.WriteLine("Conta nova Criada com Sucesso!");
Console.WriteLine($"Numero da Conta = {conta.Numero}");
Console.WriteLine($"Saldo Atual da Conta = {conta.Saldo}");
Console.WriteLine($"Titular Atual da Conta = {conta.Cliente.Nome}");

//---------------------------------------------------------------------------//
Console.WriteLine("//---------------------------------------------------------------------------//");


//Slide 31 - Criar Conta2

Console.WriteLine("Agora criamos a segunda conta:");

Console.WriteLine("Digite o numero da conta:");
long numeroConta2 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Digite o saldo da conta:");
decimal numeroSaldo2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora Crie um Cliente para associar a Conta:");

Cliente cliente2 = operação.CriarCliente();



var conta2 = new Conta(numeroConta2, numeroSaldo2, cliente2, agencia);

Console.WriteLine("Conta nova Criada com Sucesso!");
Console.WriteLine($"Numero da Conta = {conta2.Numero}");
Console.WriteLine($"Saldo Atual da Conta = {conta2.Saldo}");
Console.WriteLine($"Titular Atual da Conta = {conta2.Cliente.Nome}");


//---------------------------------------------------------------------------//
Console.WriteLine("//---------------------------------------------------------------------------//");


Console.WriteLine("Agora Testamos Tranferencias");

Console.WriteLine($"Valor atual do saldo da conta {conta.Cliente.Nome} é {conta.Saldo}");
Console.WriteLine($"Valor atual do saldo da conta {conta2.Cliente.Nome} é {conta2.Saldo}");

Console.WriteLine("Escolha um valor para tranferir:");
decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

operação.Transferir(valorTransferencia,conta,conta2);
















