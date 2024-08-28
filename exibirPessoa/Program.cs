using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exibirPessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa instPessoa = new Pessoa();

            instPessoa.metodoNome = "João";
            instPessoa.metodoIdade = 20;
            instPessoa.metodoAltura = 1.80;

            instPessoa.ExibirDados();
        }
    }
}