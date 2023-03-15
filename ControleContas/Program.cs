
using ControleContas.Model;

Conta conta = new Conta("1234");
Conta conta2 = new Conta("4321", 1000.99m);
//Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");

Conta novaConta = new Conta("654321", 2341.00m);

Console.WriteLine($"Nova Conta: {novaConta.Numero}; Saldo: {novaConta.Saldo}");
Console.WriteLine($"Saldo Total: R${novaConta.Saldo + conta2.Saldo} ");
