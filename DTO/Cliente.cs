using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade  { get; set; }
        public string Estado { get; set; }
        public string Email  { get; set; }
        public string EstadoCivil { get; set; }
        public string  RG { get; set; }
        public  string  CPF { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }
        public  DateTime Datacriacao { get; set; }
        public DateTime UltimoLogin { get; set; }

        public Cliente(string nome, string Endereco, string Cidade, string Estado, string Email, string RG, string CPF, string senha, DateTime Nascimento, DateTime DataCriacao, DateTime UltimoLogin, string EstadoCivil) 
        {
            this.Nome = nome;
            this.Endereco = Endereco;
            this.Cidade = Cidade;
            this.Estado = Estado;
            this.Email = Email;
            this.Senha = senha;
            this.RG = RG;
            this.CPF = CPF;
            this.Datacriacao = DataCriacao;
            this.DataNascimento = Nascimento;
            this.UltimoLogin = UltimoLogin;

        
        
        }
    }
}
