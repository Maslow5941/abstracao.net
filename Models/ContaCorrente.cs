namespace abstracao.net.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numConta, decimal saldoInicial)
        {
            NumConta = numConta;
            saldo = saldoInicial;

        }
        public int NumConta{get; set;}
        private decimal saldo;

        public void Sacar(decimal  valor){
            if(saldo >= valor){
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }else{
                Console.WriteLine("Saldo indisponivel para o valor informado");
            }
        }
        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}