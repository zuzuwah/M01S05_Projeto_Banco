using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S05_Exercício
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} }
       
       public PessoaFisica(){

        }
       
       public PessoaFisica(string nome, string cpf, DateTime dataNascimento, int numeroConta, string email, string telefone, string end) : base (email, telefone, end, numeroConta)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
    }

        public bool EhMaior() => Idade >= 18;

        public override string ResumoCliente() =>  $"{base.ResumoCliente} | {Nome} | {CPF}";
    }
}
