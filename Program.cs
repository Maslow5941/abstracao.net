// See https://aka.ms/new-console-template for more information
using abstracao.net.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

pessoa p1 = new pessoa();
p1.Nome = "edu";
p1.Idade = 30;

p1.Apresenta();
