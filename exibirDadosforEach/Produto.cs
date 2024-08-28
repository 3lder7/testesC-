using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercadinho
{
    public class Produto
    {
      private String nome;
      private double preco;

      public Produto(string nome, double preco)
      {
        this.nome = nome;
        this.preco = preco;
      }
      
      public String acessoNome
      {
        get {return this.nome;}
        set {this.nome = value;}
      }
      public Double acessoPreco{
        get {return this.preco;}
        set {this.preco = value;}
      }
    }
}