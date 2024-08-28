using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exibirPessoa
{
    public class Pessoa
    {
      private String nome; 
      private int idade;
      private double altura;

      public String metodoNome{
        get {return nome;}
        set {nome=value;}
      }
      public int metodoIdade{
        get {return idade;}
        set {idade=value;}
      }
      public double metodoAltura{
        get {return altura;}
        set {altura=value;}
      }

      public void ExibirDados(){
        Console.WriteLine("Nome:" + nome);
        Console.WriteLine("Idade:" + idade);
        Console.WriteLine("Altura:" + altura);
      }
    }
}