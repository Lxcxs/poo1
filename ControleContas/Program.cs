
using ControleContas.Model;

Conta conta = new Conta("1234");
Conta conta2 = new Conta("4321", 1000.99m);
//Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");

Conta conta3 = new Conta("654321", 2341.42m);

Console.WriteLine($"Nova Conta: {conta3.Numero}; Saldo: {conta3.Saldo}");
Console.WriteLine($"Saldo Total: R${conta3.SaldoTotal}");
