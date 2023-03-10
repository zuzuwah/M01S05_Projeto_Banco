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
       
        public PessoaJuridica()
       {

       }

        public PessoaJuridica(string razaoSocial, string cnpj, DateTime dataNascimento, int numeroConta, string email, string telefone,string end) : base (email, telefone, end, numeroConta)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;            

        }
        public override string ResumoCliente() => $"{base.ResumoCliente} | {RazaoSocial} | {CNPJ}";
    }
}
