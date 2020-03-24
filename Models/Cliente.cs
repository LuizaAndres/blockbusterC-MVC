using System.Collections.Generic;
using Repositories;
using System;
namespace Models {
    public class Cliente {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cpf { get; set; }
        public int QtdDias { get; set; }
        public List<Locacao> locacoes { get; set; }
        public Cliente (int id, string nome, DateTime dtNasc, string cpf, int qtdDias){
            ID = id;
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
            return $"{ID} - {Nome}";
        }
    }
}