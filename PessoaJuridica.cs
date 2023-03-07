using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S05_Exercício
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataFundacao { get; set; } 

        public PessoaJuridica(string razaoSocial, string cnpj, DateTime dataFundacao, int numeroConta, string email, string telefone,string end, string tipoConta) : base (email, telefone, end, numeroConta, tipoConta)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            DataFundacao = dataFundacao;

        }
        public override void ResumoCliente(){ 
        Console.WriteLine($"{NumeroConta}  | {RazaoSocial} |  {CNPJ}  ");
        } 
    }
}
