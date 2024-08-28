using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercadinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1  = new Produto("Camisa", 50.00);
            Produto produto2  = new Produto("Short", 40.00);
            Produto produto3  = new Produto("Tênis", 45.0);
            Produto produto4  = new Produto("Boné", 20.00);
            
            carrinhoDeCompras carrinho = new carrinhoDeCompras();

            carrinho.addProduto(produto1);
            carrinho.addProduto(produto2);
            carrinho.addProduto(produto3);
            carrinho.addProduto(produto4);
            
            carrinho.exibirCarrinho();
        }
    }
}