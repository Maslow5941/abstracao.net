// See https://aka.ms/new-console-template for more information
using abstracao.net.Models;

ContaCorrente c1 = new ContaCorrente(123, 1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

pessoa p1 = new pessoa("Eduardo",12);
Aluno a1 = new Aluno("pedro",33);
p1.Apresenta();
Corrente cor = new Corrente();
cor.Creditar(1200);
cor.ExibirSaldo();
