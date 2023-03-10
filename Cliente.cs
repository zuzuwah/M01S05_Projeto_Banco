using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M01S05_Exercício
{
    public abstract class Cliente
    {
        //public string Nome { get; set; } ---- Enviado para PF
        //public string CPF { get; set; } ---- Enviado para PF
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        //public DateTime DataNascimento { get; set; } ---- Enviado para PF
        public int NumeroConta { get; set; }
        
        public double Saldo {  get {return GetSaldo(); }  private set{} }

        //public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} } ---- Enviado para PF
        
        public List<Transacao> Extrato { get; set; } = new List<Transacao>();

        public Cliente()
        {
         
        }
        public Cliente(string email, string telefone, string end, int numeroConta) :this()
        {
            Email=email;
            Telefone =telefone; 
            Endereco = end;
            NumeroConta = numeroConta;          
        }


        public virtual string ResumoCliente() => $"{NumeroConta}";

        private double GetSaldo() => Extrato.Sum(x => x.Valor);

        //public bool EhMaior(){
          //  return Idade >= 18;
        //} ---- Enviado para PF
        
    }
}
