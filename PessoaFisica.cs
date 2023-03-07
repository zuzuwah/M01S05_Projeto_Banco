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
        public PessoaFisica(string nome, string cpf, DateTime dataNascimento, int idade, int numeroConta, string email, string telefone, string end, string tipoConta) : base (email, telefone, end, numeroConta, tipoConta)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Idade = idade;

    }

        public bool EhMaior(){
            return Idade >= 18;
        }

        public override void ResumoCliente(){ 
        Console.WriteLine($"{NumeroConta}  | {Nome} |  {CPF}  ");
        }
    }
}
