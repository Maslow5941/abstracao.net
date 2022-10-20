using System;

namespace abstracao.net.Models
{
    public class pessoa
    {

        public pessoa(String nome, int idade){
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade{ get; set;}
   
    public void Apresenta(){
        Console.WriteLine($"Oi meu nome é {Nome} eu tenho {Idade} anos");
    }

 }
}
