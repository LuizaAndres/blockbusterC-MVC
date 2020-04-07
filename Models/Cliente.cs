using System.Collections.Generic;
using Repositories;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models {
    public class Cliente {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public int QtdDias { get; set; }
        public List<Locacao> locacoes { get; set; }
        public Cliente(){

        }
        public Cliente (int id, string nome, DateTime dtNasc, string cpf, int qtdDias){
            ClienteId = id;
            Nome = nome;
            DtNasc = dtNasc;
            Cpf = cpf;
            QtdDias = qtdDias;
            locacoes = new List<Locacao> ();
        }
        public static List<Cliente> GetClientes () {
            return RepositoryCliente.Clientes();
        }
        public override string ToString(){
            return $"{ClienteId} - {Nome}";
        }
    }
}