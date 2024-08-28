using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercadinho
{
  
  public class carrinhoDeCompras{

    List<Produto> listaDeProdutos = new List<Produto>();

    public void addProduto(Produto produto){
      listaDeProdutos.Add(produto);
    }

    public void exibirCarrinho(){
      
      Console.WriteLine("Carrinho de Compras:");
     foreach(Produto produto in listaDeProdutos)
      {
       Console.WriteLine("Nome: "+produto.acessoNome+" Preço:"+produto.acessoPreco);
     }
    }
  }
}