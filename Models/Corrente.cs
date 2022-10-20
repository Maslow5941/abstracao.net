using System;
namespace abstracao.net.Models
{
    public class Corrente : Conta
    {
   

    public override void Creditar (decimal valor){
            saldo += valor;
            
        }
        
    }
}