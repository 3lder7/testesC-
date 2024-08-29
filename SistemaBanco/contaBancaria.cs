using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class contaBancaria
    {
      dadosConta instDados = new dadosConta();
        
      public void Depositar(decimal valor){
          if(valor <= 0)
          {
              throw new Exception("ERRO! Ao adicionar saldo na conta, não pode ser negativo.");
          }else{
            instDados.acessoSaldo += valor;
          }
      }
        public decimal obterSaldo(){
            return instDados.acessoSaldo;
        }
        
    }
}