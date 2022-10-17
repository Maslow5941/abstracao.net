using System;

namespace abstracao.net.Models
{
    public class pessoa
    {
        public string Nome { get; set; }
        public int Idade{ get; set;}
   
    public void Apresenta(){
        Console.WriteLine($"Oi meu nome é {Nome} eu tenho {Idade} anos");
    }

 }
}
