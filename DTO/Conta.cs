using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pjrAtiv.Classes;




namespace pjrAtiv.Classes
{
    public class Conta
    {

        public int IdConta { get; set; }
        public int IdCliente { get; set; }

        public decimal Saldo { get; set; }
        public string? Status { get; set; }
        public double Limite { get; set; }

        
        public DateTime DataEncerramento { get; set; }

        public Conta() 
        { 
            
            
        
        }
        public Conta(int Idconta, int Idcliente, decimal saldo, string status) 
        {
            this.IdConta = Idconta;
            this.IdCliente = Idcliente;
            this.Saldo = saldo;
            this.Status = status;
        
        
        
        }
        public Conta(int Idcliente, decimal saldo, string status)
        {
            this.IdCliente = Idcliente;
            this.Saldo = saldo;
            this.Status = status;



        }


        public delegate void teste(int conta);
        public decimal Depositar(decimal ValorDeposito) 
        {

            this.Saldo += ValorDeposito;
            return this.Saldo;
        
        
        
        }

        
        
    }
}
