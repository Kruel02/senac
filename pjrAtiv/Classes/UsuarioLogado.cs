using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Runtime.CompilerServices;

namespace pjrAtiv.Classes
{
    public static class UsuarioLogado 
    {
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Endereco { get; set; }
        public static string Cidade { get; set; }
        public static string EstadoCliente { get; set; }
        public static string EstadoCivil { get; set; }
        public static DateTime DataNascimento { get; set; }
        public static string Email  { get; set; }
        public static string Telefone  { get; set; }
        public static string RG { get; set; }
        public static string CPF { get; set; }
        public static string Senha { get; set; }
        public static DateTime DataCriacao { get; set; }
        public static DateTime UltimoLogin { get; set; }


        public static List<Conta> Contas = new List<Conta>();
        public static List<Cliente> clientes = new List<Cliente>();


        public static void Deslogar()
        {
            UsuarioLogado.Id = 0;
            UsuarioLogado.Nome = string.Empty;
            UsuarioLogado.Endereco = string.Empty;
            UsuarioLogado.EstadoCliente = string.Empty;
            UsuarioLogado.EstadoCivil = string.Empty;
            UsuarioLogado.Email = string.Empty;
            UsuarioLogado.Telefone = string.Empty;
            UsuarioLogado.RG = string.Empty;
            UsuarioLogado.CPF = string.Empty;
           

        }
       
    }
}

