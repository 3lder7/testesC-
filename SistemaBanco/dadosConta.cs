using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class dadosConta
    {
        private int numeroConta;
        private String Titular;
        private decimal Saldo;

        public int acessoNumero{
            get{
                return numeroConta;
                }
            set{
                if(value <= 0)
                {
                    throw new Exception("ERRO! O número da conta deve ser maior que zero.");
                }else
                {
                    numeroConta = value;
                }
            }
        }

        public String acessoTitular{
            get{
                return Titular;
                }
            set{
                if(value == null)
                {
                    throw new Exception("ERRO! O titular da conta não pode ser nulo.");
                }else
                {
                    Titular = value;
                }
            }
        }

        public decimal acessoSaldo{
            get{
                return Saldo;
                }
            set
            {
                if(value < 0)
                {
                    throw new Exception("ERRO! O saldo da conta não pode ser negativo.");
                }else
                {
                    Saldo += value;
                }
            }
        }
    
    }
        
}